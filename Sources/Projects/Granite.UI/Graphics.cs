using Granite.Core;
using Granite.UI.Shaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class Graphics
    {
        private const int QUAD_COUNT = 10000;

        private struct QuadData
        {
            public Vector2i Position;
            public Vector2i Size;
            public Color4ub Color;
            // public Vector4 TextureCoordinates;
        }

        private readonly Buffer<Vector2> m_vertices;
        private readonly Buffer<QuadData> m_buffer;
        private readonly QuadData[] m_quads;
        private readonly QuadProgram m_program;
        private readonly VertexArray m_vertexArray;
        private int m_count;

        public Graphics()
        {
            m_quads = new QuadData[QUAD_COUNT];

            m_vertices = new Buffer<Vector2>();
            m_vertices.SetData(new Vector2[] {
                new Vector2(0,0),
                new Vector2(0,1),
                new Vector2(1,1),
                new Vector2(1,0)
            });

            m_buffer = new Buffer<QuadData>();
            m_buffer.SetData(QUAD_COUNT, GL.STREAM_DRAW);

            m_program = QuadProgram.Instance;
            m_vertexArray = new VertexArray();

            GL.UseProgram(m_program);
            GL.BindVertexArray(m_vertexArray);

            m_program.Vertex.SetValue(m_vertices.GetView());

            m_program.Position.SetValue(m_buffer.GetView<Vector2i>("Position"));
            m_program.Position.SetDivisor(1);

            m_program.Size.SetValue(m_buffer.GetView<Vector2i>("Size"));
            m_program.Size.SetDivisor(1);

            m_program.Color.SetValue(m_buffer.GetView<Color4ub>("Color"));
            m_program.Color.SetDivisor(1);

            GL.BindVertexArray(null);
        }

        public void Flush()
        {
            if (m_count > 0)
            {
                m_buffer.SetSubData(m_quads, 0, m_count);

                GL.UseProgram(m_program);
                GL.BindVertexArray(m_vertexArray);

                m_program.ScreenSize.SetValue(Engine.Display.GetSize());

                GL.DrawArraysInstanced(GL.TRIANGLE_FAN, 0, 4, m_count);

                GL.BindVertexArray(null);

                m_count = 0;
            }
        }

        public void Clear()
        {
            m_count = 0;
        }

        public void FillRectangle(Box2i rectangle, Color4ub color)
        {
            if (m_count == QUAD_COUNT)
            {
                Flush();
            }

            m_quads[m_count++] = new QuadData() {
                Position = new Vector2i(rectangle.Position.X, rectangle.Position.Y),
                Size = new Vector2i(rectangle.Size.X, rectangle.Size.Y),
                Color = color
            };
        }
    }
}
