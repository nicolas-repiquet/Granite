using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Test.Game_01.Shaders;

namespace Test.Game_01.Sprites
{
    public sealed class SpriteRenderer
    {
        private struct SpriteData
        {
            public Vector4 Color;
            public Matrix4 Transform;
            public Vector2 TextureCoordinates0;
            public Vector2 TextureCoordinates1;
            public Vector2 TextureCoordinates2;
            public Vector2 TextureCoordinates3;
        }

        private sealed class SpriteInstance : ISpriteInstance
        {

            private readonly SpriteRenderer m_renderer;

            public SpriteInstance(SpriteRenderer renderer, Sprite sprite)
            {
                m_renderer = renderer;
                m_sprite = sprite;
            }

            private Sprite m_sprite;
            public Sprite Sprite
            {
                get { return m_sprite; }
                set
                {
                    if (m_sprite != value)
                    {
                        m_sprite = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }

            private Vector2d m_position;
            public Vector2d Position
            {
                get { return m_position; }
                set
                {
                    if (m_position != value)
                    {
                        m_position = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }

            private Vector2d m_size;
            public Vector2d Size
            {
                get { return m_size; }
                set
                {
                    if (m_size != value)
                    {
                        m_size = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }
        }

        private readonly SpriteProgram m_program;
        private readonly List<SpriteInstance> m_instances;
        private readonly Buffer<SpriteData> m_bufferSprite;
        private readonly Buffer<Vector3> m_bufferQuad;
        private readonly IBufferView m_positionView;
        private readonly IBufferView m_textureCoordinatesView;

        private readonly Vector3 m_p0 = new Vector3(0f, 0f, 0f);
        private readonly Vector3 m_p1 = new Vector3(0f, 1f, 0f);
        private readonly Vector3 m_p2 = new Vector3(1f, 1f, 0f);
        private readonly Vector3 m_p3 = new Vector3(1f, 0f, 0f);

        public SpriteSheet SpriteSheet { get; private set; }

        private bool m_isDirty;
        private uint m_vao;

        public SpriteRenderer(SpriteSheet spriteSheet)
        {
            m_program = SpriteProgram.Instance;
            
            m_instances = new List<SpriteInstance>();

            GL.GenVertexArrays(1, out m_vao);
            GL.BindVertexArray(m_vao);

            m_bufferSprite = new Buffer<SpriteData>();
            m_bufferQuad = new Buffer<Vector3>();

            GL.BindVertexArray(0);

            SpriteSheet = spriteSheet;

            try
            {

                BuildBuffer();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + ", " + e.StackTrace);
            }

            m_isDirty = true;
        }

        public ISpriteInstance AddSprite(Sprite sprite)
        {
            Contract.Requires(sprite != null && sprite.SpriteSheet == SpriteSheet);

            var instance = new SpriteInstance(this, sprite);
            m_instances.Add(instance);

            instance.Size = new Vector2d(sprite.Size.X, sprite.Size.Y);

            return instance;
        }

        public void Render(Matrix4 transform)
        {
            try
            {
                if (m_isDirty)
                {
                    RebuildBuffer();
                }

            
                GL.UseProgram(m_program);

                GL.BindVertexArray(m_vao);

                m_program.Projection.SetValue(transform);
                m_program.Texture.SetValue(SpriteSheet.Texture);

                GL.DrawArraysInstanced(GL.TRIANGLE_FAN, 0, 4, m_bufferSprite.Count);
                //GL.DrawArraysInstanced(GL.POINTS, 0, 4, m_bufferSprite.Count);

                GL.BindVertexArray(0);

                GL.UseProgram(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + ", " + e.StackTrace);
            }
        }

        private void BuildBuffer()
        {
            Vector3[] vertices = new Vector3[4]
            {
                    m_p0,
                    m_p1,
                    m_p2,
                    m_p3
            };

            //=================================================

            GL.UseProgram(m_program);

            GL.BindVertexArray(m_vao);

            m_bufferQuad.SetData(vertices);
            m_program.Position.SetValue(m_bufferQuad.GetView());

            //===================================================
            var listInstances = new List<SpriteData>(m_instances.Count);

            foreach (var instance in m_instances)
            {
                var sprite = instance.Sprite;

                var matrix = Matrix4.Identity * Matrix4.Translate(
                    (float)instance.Position.X,
                    (float)instance.Position.Y,
                    0f);
                matrix *= Matrix4.Scale((float)instance.Size.X, (float)instance.Size.Y, 0f);


                var data = new SpriteData()
                {
                    Color = new Vector4(1f, 1f ,1f, 1f),
                    Transform = matrix
                };

                listInstances.Add(data);
            }

            m_bufferSprite.SetData(listInstances.ToArray());

            m_program.Color.SetValue(m_bufferSprite.GetView("Color"));
            m_program.Color.SetDivisor(1);
            m_program.Transform.SetValue(m_bufferSprite.GetView("Transform"));
            m_program.Transform.SetDivisor(1);
            m_program.TextureCoordinates0.SetValue(m_bufferSprite.GetView("TextureCoordinates0"));
            m_program.TextureCoordinates0.SetDivisor(1);
            m_program.TextureCoordinates1.SetValue(m_bufferSprite.GetView("TextureCoordinates1"));
            m_program.TextureCoordinates1.SetDivisor(1);
            m_program.TextureCoordinates2.SetValue(m_bufferSprite.GetView("TextureCoordinates2"));
            m_program.TextureCoordinates2.SetDivisor(1);
            m_program.TextureCoordinates3.SetValue(m_bufferSprite.GetView("TextureCoordinates3"));
            m_program.TextureCoordinates3.SetDivisor(1);

            GL.BindVertexArray(0);

            GL.UseProgram(null);
        }

        private void RebuildBuffer()
        {
            var listInstances = new List<SpriteData>(m_instances.Count);

            foreach (var instance in m_instances)
            {
                var sprite = instance.Sprite;

                //var matrix = Matrix4.Identity * Matrix4.Scale((float)instance.Size.X, (float)instance.Size.Y, 0f);
                //matrix = matrix * Matrix4.Translate(
                //    (float)instance.Position.X,
                //    0,
                //    0f);

                var matrix = Matrix4.Identity *  Matrix4.Translate(
                    (float)instance.Position.X,
                    (float)instance.Position.Y,
                    0f);
                matrix *= Matrix4.Scale((float)instance.Size.X, (float)instance.Size.Y, 0f);

                var data = new SpriteData()
                {
                    Color = new Vector4(1f, 1f ,1f, 1f),
                    Transform = matrix,
                    TextureCoordinates0 = new Vector2((float)sprite.Coordinates.MinX, (float)sprite.Coordinates.MaxY),
                    TextureCoordinates1 = new Vector2((float)sprite.Coordinates.MinX, (float)sprite.Coordinates.MinY),
                    TextureCoordinates2 = new Vector2((float)sprite.Coordinates.MaxX, (float)sprite.Coordinates.MinY),
                    TextureCoordinates3 = new Vector2((float)sprite.Coordinates.MaxX, (float)sprite.Coordinates.MaxY)
                };

                listInstances.Add(data);
            }

            m_bufferSprite.SetData(listInstances.ToArray());

            GL.UseProgram(m_program);

            GL.BindVertexArray(m_vao);

            m_program.Color.SetValue(m_bufferSprite.GetView("Color"));
            m_program.Transform.SetValue(m_bufferSprite.GetView("Transform"));
            m_program.TextureCoordinates0.SetValue(m_bufferSprite.GetView("TextureCoordinates0"));
            m_program.TextureCoordinates1.SetValue(m_bufferSprite.GetView("TextureCoordinates1"));
            m_program.TextureCoordinates2.SetValue(m_bufferSprite.GetView("TextureCoordinates2"));
            m_program.TextureCoordinates3.SetValue(m_bufferSprite.GetView("TextureCoordinates3"));

            GL.BindVertexArray(0);

            GL.UseProgram(null);

            m_isDirty = false;
        }
    }
}
