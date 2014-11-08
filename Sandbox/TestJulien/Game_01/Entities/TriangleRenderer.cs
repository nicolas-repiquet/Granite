using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using TestJulien.Game_01.Shaders;

namespace TestJulien.Game_01
{
    public sealed class TriangleRenderer
    {
        private struct TriangleData
        {
            public Vector4 Color;
            public Vector3 Position;
        }

        private sealed class TriangleInstance : ITriangleInstance
        {

            private readonly TriangleRenderer m_renderer;

            public TriangleInstance(TriangleRenderer renderer)
            {
                m_renderer = renderer;
            }

            private Vector4 m_color;
            public Vector4 Color
            {
                get { return m_color; }
                set
                {
                    if (m_color != value)
                    {
                        m_color = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }

            private Vector3 m_p1;
            public Vector3 P1
            {
                get { return m_p1; }
                set
                {
                    if (m_p1 != value)
                    {
                        m_p1 = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }

            private Vector3 m_p2;
            public Vector3 P2
            {
                get { return m_p2; }
                set
                {
                    if (m_p2 != value)
                    {
                        m_p2 = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }

            private Vector3 m_p3;
            public Vector3 P3
            {
                get { return m_p3; }
                set
                {
                    if (m_p3 != value)
                    {
                        m_p3 = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }
        }

        private readonly TriangleProgram m_program;
        private readonly List<TriangleInstance> m_instances;
        private readonly Buffer<TriangleData> m_bufferSprite;
        private readonly Buffer<Vector3> m_bufferTriangle;
        private readonly VertexArray m_vao;

        private bool m_isDirty;

        public TriangleRenderer()
        {
            m_program = TriangleProgram.Instance;
            m_instances = new List<TriangleInstance>();
            
            
            m_vao = new VertexArray();

            GL.BindVertexArray(m_vao);
            GL.UseProgram(m_program);

            m_bufferSprite = new Buffer<TriangleData>();
            m_bufferTriangle = new Buffer<Vector3>();

            m_program.Position.SetValue(m_bufferSprite.GetView<Vector3>("Position"));

            m_program.Color.SetValue(m_bufferSprite.GetView<Vector4>("Color"));
            //m_program.Position.SetDivisor(1);
           // m_program.Normal.SetValue(m_bufferSprite.GetView<Vector3>("Normal"));
           //// m_program.Normal.SetDivisor(1);
           // m_program.Transform.SetValue(m_bufferSprite.GetView<Matrix4>("Transform"));
           // //m_program.Transform.SetDivisor(1);
           // m_program.TextureOrigin.SetValue(m_bufferSprite.GetView<Vector2>("TextureOrigin"));
           // //m_program.TextureOrigin.SetDivisor(1);
           // m_program.TextureTarget.SetValue(m_bufferSprite.GetView<Vector2>("TextureTarget"));
            //m_program.TextureTarget.SetDivisor(1);

            GL.BindVertexArray(null);

            m_isDirty = true;
        }

        public void Clear()
        {
            m_instances.Clear();
        }

        public ITriangleInstance AddTriangle(Triangle triangle)
        {
            var instance = new TriangleInstance(this);
            m_instances.Add(instance);

            instance.P1 = triangle.P1;
            instance.P2 = triangle.P2;
            instance.P3 = triangle.P3;
            instance.Color = triangle.Color;

            return instance;
        }

        public void Render(Matrix4 transform)
        {
            if (m_isDirty)
            {
                GL.BindVertexArray(m_vao);
                RebuildBuffer();
            }

            GL.UseProgram(m_program);
            GL.BindVertexArray(m_vao);

            m_program.Projection.SetValue(transform);

            GL.DrawArrays(GL.TRIANGLES, 0, m_instances.Count*3);

            GL.BindVertexArray(null);

        }

        private void RebuildBuffer()
        {
            TriangleData[] data = new TriangleData[m_instances.Count*3];

            for (int i = 0; i < m_instances.Count*3; i=i+3)
            {
                var instance = m_instances[i/3];

                var matrix = Matrix4.Identity;
                
                data[i] = new TriangleData()
                {
                    Color = instance.Color,
                    Position = instance.P1
                };

                data[i+1] = new TriangleData()
                {
                    Color = instance.Color,
                    Position = instance.P2
                };

                data[i+2] = new TriangleData()
                {
                    Color = instance.Color,
                    Position = instance.P3
                };
            }

            m_bufferSprite.SetData(data, GL.STREAM_DRAW);

            m_isDirty = false;
        }

        
    }
}
