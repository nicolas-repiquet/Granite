using Granite.Core;
using Granite.UI.Shaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite.UI
{
    public sealed class Graphics
    {
        private const int TEXTURE_QUEUE_CAPACITY = 8;

        [StructLayout(LayoutKind.Sequential)]
        private struct QuadData
        {
            public Vector2 TextureCoordinates0;
            public Vector2 TextureCoordinates1;
            public Color4ub Color;
            public Matrix3x2 Transform;
            public int Texture;
        }

        private readonly Stack<Matrix3x2> m_transformStack;
        private Matrix3x2 m_transform;

        private readonly QuadProgram m_program;
        private readonly VertexArray m_vertexArray;

        private readonly Buffer<Vector2> m_verticesBuffer;
        private readonly Buffer<QuadData> m_quadsBuffer;

        private readonly QuadData[] m_queue;
        private readonly int m_queueCapacity;
        private int m_queueSize;
        private readonly Texture2D[] m_textureQueue;
        private int m_textureQueueSize;

        public Graphics(int queueCapacity = 1000)
        {
            m_queueCapacity = queueCapacity;
            m_queue = new QuadData[m_queueCapacity];
            m_textureQueue = new Texture2D[TEXTURE_QUEUE_CAPACITY];

            m_transformStack = new Stack<Matrix3x2>();

            m_verticesBuffer = new Buffer<Vector2>();
            m_verticesBuffer.SetData(new Vector2[] {
                new Vector2(0,0),
                new Vector2(0,1),
                new Vector2(1,1),
                new Vector2(1,0)
            });

            m_quadsBuffer = new Buffer<QuadData>();
            m_quadsBuffer.SetData(m_queueCapacity, GL.STREAM_DRAW);

            m_program = QuadProgram.Instance;
            m_vertexArray = new VertexArray();

            GL.UseProgram(m_program);
            GL.BindVertexArray(m_vertexArray);

            m_program.Vertex.SetValue(m_verticesBuffer.GetView());

            m_program.TextureCoordinates0.SetValue(m_quadsBuffer.GetView<Vector2>("TextureCoordinates0"));
            m_program.TextureCoordinates0.SetDivisor(1);

            m_program.TextureCoordinates1.SetValue(m_quadsBuffer.GetView<Vector2>("TextureCoordinates1"));
            m_program.TextureCoordinates1.SetDivisor(1);

            m_program.Transform.SetValue(m_quadsBuffer.GetView<Matrix3x2>("Transform"));
            m_program.Transform.SetDivisor(1);

            m_program.Color.SetValue(m_quadsBuffer.GetView<Color4ub>("Color"));
            m_program.Color.SetDivisor(1);

            m_program.Texture.SetValue(m_quadsBuffer.GetView<int>("Texture"));
            m_program.Texture.SetDivisor(1);

            GL.BindVertexArray(null);

            Clear();
        }

        public void Flush()
        {
            if (m_queueSize > 0)
            {
                m_quadsBuffer.SetSubData(m_queue, 0, m_queueSize);

                GL.UseProgram(m_program);

                GL.BindVertexArray(m_vertexArray);

                for (int i = 0; i < m_textureQueueSize; i++)
                {
                    m_program.Textures[i].SetValue(m_textureQueue[i]);
                }

                GL.DrawArraysInstanced(GL.TRIANGLE_FAN, 0, 4, m_queueSize);
                GL.DrawArrays(GL.TRIANGLE_FAN, 0, 4);

                GL.BindVertexArray(null);

                m_queueSize = 0;
                m_textureQueueSize = 0;
            }
        }

        public void Clear()
        {
            m_queueSize = 0;
            m_transformStack.Clear();
            m_transform = Matrix3x2.Identity;
        }

        public void PushTransform()
        {
            m_transformStack.Push(m_transform);
        }

        public void PopTransform()
        {
            m_transform = m_transformStack.Pop();
        }

        public void Translate(Vector2 v)
        {
            // M00 M10 M20
            // M01 M11 M21

            // 1   0   v.X
            // 0   1   v.Y

            m_transform = new Matrix3x2(
                m_transform.M00,
                m_transform.M01,

                m_transform.M10,
                 m_transform.M11,

                m_transform.M00 * v.X + m_transform.M10 * v.Y + m_transform.M20,
                m_transform.M01 * v.X + m_transform.M11 * v.Y + m_transform.M21
            );
        }

        public void Scale(Vector2 v)
        {
            // M00 M10 M20
            // M01 M11 M21

            // v.X 0   0
            // 0   v.Y 0

            m_transform = new Matrix3x2(
                m_transform.M00 * v.X,
                m_transform.M01 * v.X,

                m_transform.M10 * v.Y,
                m_transform.M11 * v.Y,

                m_transform.M20,
                m_transform.M21
            );
        }

        public void Rotate(float angle)
        {
            // M00 M10 M20
            // M01 M11 M21

            // c   s   0
            // -s   c  0

            var c = (float)Math.Cos(angle);
            var s = (float)Math.Sin(angle);

            m_transform = new Matrix3x2(
                m_transform.M00 * c - m_transform.M10 * s,
                m_transform.M01 * c - m_transform.M11 * s,

                m_transform.M00 * s + m_transform.M10 * c,
                m_transform.M01 * s + m_transform.M11 * c,

                m_transform.M20,
                m_transform.M21
            );
        }

        public void Ortho(float left, float right, float bottom, float top)
        {
            var right_minus_left = right - left;
            var top_minus_bottom = top - bottom;

            m_transform = new Matrix3x2(
                2 / right_minus_left, 0,
                0, 2 / top_minus_bottom,
                -(right + left) / right_minus_left,
                -(top + bottom) / top_minus_bottom
            );
        }

        private int GetTextureIndex(Texture2D texture)
        {
            for (int i = 0; i < m_textureQueueSize; i++)
            {
                if (m_textureQueue[i] == texture)
                {
                    return i;
                }
            }

            if (m_textureQueueSize == TEXTURE_QUEUE_CAPACITY)
            {
                Flush();
            }

            m_textureQueue[m_textureQueueSize] = texture;

            return m_textureQueueSize++;
        }

        public void Draw(Box2 rectangle, Color4ub color)
        {
            if (m_queueSize == m_queueCapacity)
            {
                Flush();
            }

            m_queue[m_queueSize++] = new QuadData()
            {
                Transform = new Matrix3x2(
                    m_transform.M00 * rectangle.Size.X,
                    m_transform.M01 * rectangle.Size.X,

                    m_transform.M10 * rectangle.Size.Y,
                    m_transform.M11 * rectangle.Size.Y,

                    m_transform.M00 * rectangle.Position.X + m_transform.M10 * rectangle.Position.Y + m_transform.M20,
                    m_transform.M01 * rectangle.Position.X + m_transform.M11 * rectangle.Position.Y + m_transform.M21
                ),
                Color = color,
                Texture = -1
            };
        }

        public void Draw(Box2 rectangle, Sprite sprite)
        {
            Draw(rectangle, sprite.Texture, sprite.TextureCoordinates0, sprite.TextureCoordinates1, new Color4ub(0xFF, 0xFF, 0xFF, 0xFF));
        }

        public void Draw(Box2 rectangle, Sprite sprite, Color4ub color)
        {
            Draw(rectangle, sprite.Texture, sprite.TextureCoordinates0, sprite.TextureCoordinates1, color);
        }

        public void Draw(Box2 rectangle, Texture2D texture, Vector2 textureCoordinates0, Vector2 textureCoordinates1)
        {
            Draw(rectangle, texture, textureCoordinates0, textureCoordinates1, new Color4ub(0xFF, 0xFF, 0xFF, 0xFF));
        }

        public void Draw(Box2 rectangle, Texture2D texture, Vector2 textureCoordinates0, Vector2 textureCoordinates1, Color4ub color)
        {
            if (m_queueSize == m_queueCapacity)
            {
                Flush();
            }

            m_queue[m_queueSize++] = new QuadData()
            {
                Transform = new Matrix3x2(
                    m_transform.M00 * rectangle.Size.X,
                    m_transform.M01 * rectangle.Size.X,

                    m_transform.M10 * rectangle.Size.Y,
                    m_transform.M11 * rectangle.Size.Y,

                    m_transform.M00 * rectangle.Position.X + m_transform.M10 * rectangle.Position.Y + m_transform.M20,
                    m_transform.M01 * rectangle.Position.X + m_transform.M11 * rectangle.Position.Y + m_transform.M21
                ),
                Color = color,
                Texture = (sbyte)GetTextureIndex(texture),
                TextureCoordinates0 = textureCoordinates0,
                TextureCoordinates1 = textureCoordinates1
            };
        }

        public void Draw(Vector2 position, Font font, string text)
        {
            Draw(position, font, text, new Color4ub(0xFF, 0xFF, 0xFF, 0xFF));
        }

        public void Draw(Vector2 position, Font font, string text, Color4ub color)
        {
            foreach (var c in text)
            {
                var glyph = font.GetGlyph(c);

                if (glyph != null)
                {
                    Draw(new Box2(position, glyph.Size), glyph.Sprite, color);
                    position = new Vector2(position.X + glyph.Size.X, position.Y);
                }
            }
        }
    }
}
