using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Zombie.Game.Shaders;

namespace Zombie.Game.Entities.Tools
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

            private Vector4 m_colorP1;
            private Vector4 m_colorP2;
            private Vector4 m_colorP3;
            public Vector4 ColorP1
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
            public Vector4 ColorP2
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
            public Vector4 ColorP3
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

            m_program.Color.SetValue(m_bufferSprite.GetView<Vector4>("Color"));
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
        }

        public ITriangleInstance AddTriangle(Triangle triangle)
        {
            var instance = new TriangleInstance(this);
            lock (m_instances)
            {
                m_instances.Add(instance);
            }

            instance.P1 = triangle.P1;
            instance.P2 = triangle.P2;
            instance.P3 = triangle.P3;
            instance.ColorP1 = triangle.ColorP1;
            instance.ColorP2 = triangle.ColorP2;
            instance.ColorP3 = triangle.ColorP3;

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

            GL.DrawArrays(GL.TRIANGLES, 0, m_instances.Count * 3);

            GL.BindVertexArray(null);
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

                for (int i = 0; i < length * 3; i = i + 3)
                {
                    var instance = tempInstances[i / 3];

                    var matrix = Matrix4.Identity;

                    data[i] = new TriangleData()
                    {
                        Color = instance.ColorP1,
                        Position = instance.P1
                    };

                    data[i + 1] = new TriangleData()
                    {
                        Color = instance.ColorP2,
                        Position = instance.P2
                    };

                    data[i + 2] = new TriangleData()
                    {
                        Color = instance.ColorP3,
                        Position = instance.P3
                    };
                }

                m_bufferSprite.SetData(data, GL.STREAM_DRAW);
            }

            m_isDirty = false;
        }

        
    }
}
