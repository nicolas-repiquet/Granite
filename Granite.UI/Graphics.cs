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
        private struct QuadData
        {
            public Vector2 Position;
            public Vector2 Size;
        }

        private readonly List<QuadData> m_quads;
        private readonly Buffer<Vector2> m_vertices;
        private readonly Buffer<QuadData> m_buffer;
        private readonly QuadProgram m_program;
        private readonly VertexArray m_vertexArray;

        public Graphics()
        {
            m_quads = new List<QuadData>();

            m_vertices = new Buffer<Vector2>();
            m_vertices.SetData(new Vector2[] {
                new Vector2(0,0),
                new Vector2(0,1),
                new Vector2(1,1),
                new Vector2(1,0)
            });

            m_buffer = new Buffer<QuadData>();

            m_program = QuadProgram.Instance;
            m_vertexArray = new VertexArray();

            GL.UseProgram(m_program);
            GL.BindVertexArray(m_vertexArray);

            m_program.Vertex.SetValue(m_vertices.GetView());

            m_program.Position.SetValue(m_buffer.GetView<Vector2>("Position"));
            m_program.Position.SetDivisor(1);

            m_program.Size.SetValue(m_buffer.GetView<Vector2>("Size"));
            m_program.Size.SetDivisor(1);

            GL.BindVertexArray(null);
            GL.UseProgram(null);
        }

        public void Render()
        {
            if (m_quads.Count > 0)
            {
                m_buffer.SetData(m_quads.ToArray());

                GL.UseProgram(m_program);
                GL.BindVertexArray(m_vertexArray);

                m_program.ScreenSize.SetValue(Engine.Display.GetSize());

                GL.DrawArraysInstanced(GL.TRIANGLE_FAN, 0, 4, m_quads.Count);

                GL.BindVertexArray(null);
                GL.UseProgram(null);
            }
        }

        public void Clear()
        {
            m_quads.Clear();
        }

        public void FillRectangle(Box2 rectangle)
        {
            m_quads.Add(new QuadData() {
                Position = rectangle.Position,
                Size = rectangle.Size
            });
        }
    }
}
