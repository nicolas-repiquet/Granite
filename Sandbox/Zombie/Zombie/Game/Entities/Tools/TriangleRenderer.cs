using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Shaders;

namespace Zombie.Game.Entities.Tools
{
    public sealed class TriangleRenderer
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct TriangleData
        {
            public Color4ub Color;
            public Vector3 Position;
        }

        private sealed class TriangleInstance : ITriangleInstance
        {

            private readonly TriangleRenderer m_renderer;

            public TriangleInstance(TriangleRenderer renderer)
            {
                m_renderer = renderer;
            }

            private Color4ub m_colorP1;
            private Color4ub m_colorP2;
            private Color4ub m_colorP3;
            public Color4ub ColorP1
            {
                get { return m_colorP1; }
                set
                {
                    if (m_colorP1 != value)
                    {
                        m_colorP1 = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }
            public Color4ub ColorP2
            {
                get { return m_colorP2; }
                set
                {
                    if (m_colorP2 != value)
                    {
                        m_colorP2 = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }
            public Color4ub ColorP3
            {
                get { return m_colorP3; }
                set
                {
                    if (m_colorP3 != value)
                    {
                        m_colorP3 = value;
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
            //m_program.Position.SetDivisor(1);

            m_program.Color.SetValue(m_bufferSprite.GetView<Color4ub>("Color"));
            //m_program.Color.SetDivisor(3);
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
            lock (m_instances)
            {
                m_instances.Clear();
            }
            m_isDirty = true;
        }

        public ITriangleInstance AddTriangle(Triangle triangle)
        {
            var instance = new TriangleInstance(this);
            
            instance.P1 = triangle.P1;
            instance.P2 = triangle.P2;
            instance.P3 = triangle.P3;
            instance.ColorP1 = triangle.ColorP1;
            instance.ColorP2 = triangle.ColorP2;
            instance.ColorP3 = triangle.ColorP3;

            lock (m_instances)
            {
                m_instances.Add(instance);
            }

            return instance;
        }

        public void Render(Matrix4 transform)
        {
            
            if (m_isDirty)
            {
                RebuildBuffer();
            }

            if (m_instances.Count != 0)
            {
                GL.BindVertexArray(m_vao);
                GL.UseProgram(m_program);

                m_program.Projection.SetValue(transform);

                GL.DrawArrays(GL.TRIANGLES, 0, m_instances.Count * 3);

                //GL.BindVertexArray(null);
            }
        }

        private void RebuildBuffer()
        {
            List<TriangleInstance> tempInstances = null;
            lock (m_instances)
            {
                tempInstances = new List<TriangleInstance>(m_instances);
            }

            var length = tempInstances.Count;

            if (length != 0)
            {
                TriangleData[] data = new TriangleData[length * 3];

                Parallel.For(0, length, i =>
                    {
                        var instance = tempInstances[i];

                        var matrix = Matrix4.Identity;

                        data[i * 3] = new TriangleData()
                        {
                            Color = instance.ColorP1,
                            Position = instance.P1
                        };

                        data[(i * 3) + 1] = new TriangleData()
                        {
                            Color = instance.ColorP2,
                            Position = instance.P2
                        };

                        data[(i * 3) + 2] = new TriangleData()
                        {
                            Color = instance.ColorP3,
                            Position = instance.P3
                        };
                    });

                GL.BindVertexArray(m_vao);
                m_bufferSprite.SetData(data, GL.STREAM_DRAW);
            }
            else
            {
                GL.BindVertexArray(m_vao);
                m_bufferSprite.SetData(null, GL.STREAM_DRAW);
            }

            m_isDirty = false;
        }

        
    }
}
