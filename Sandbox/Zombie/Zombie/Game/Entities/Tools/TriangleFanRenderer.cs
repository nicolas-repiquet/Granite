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
    public sealed class TriangleFanRenderer
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct PointData
        {
            public Color4ub Color;
            public Vector3 Position;
        }

        private sealed class PointInstance : IPointInstance
        {

            private readonly TriangleFanRenderer m_renderer;

            public PointInstance(TriangleFanRenderer renderer)
            {
                m_renderer = renderer;
            }

            private Color4ub m_color;
            public Color4ub Color
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
            
            private Vector3 m_p;
            public Vector3 P
            {
                get { return m_p; }
                set
                {
                    if (m_p != value)
                    {
                        m_p = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }
        }

        private readonly TriangleProgram m_program;
        private readonly List<PointInstance> m_instances;
        private readonly Buffer<PointData> m_bufferSprite;
        private readonly Buffer<Vector3> m_bufferTriangle;
        private readonly VertexArray m_vao;

        private bool m_isDirty;

        public TriangleFanRenderer()
        {
            m_program = TriangleProgram.Instance;
            m_instances = new List<PointInstance>();
            
            
            m_vao = new VertexArray();

            GL.BindVertexArray(m_vao);
            GL.UseProgram(m_program);

            m_bufferSprite = new Buffer<PointData>();
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

        public IPointInstance AddVertex(Vector3 position, Color4ub color)
        {
            var instance = new PointInstance(this);

            instance.P = position;
            instance.Color = color;

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

                GL.DrawArrays(GL.TRIANGLE_FAN, 0, m_instances.Count);

                //GL.BindVertexArray(null);
            }
        }

        private void RebuildBuffer()
        {
            List<PointInstance> tempInstances = null;
            lock (m_instances)
            {
                tempInstances = new List<PointInstance>(m_instances);
            }

            var length = tempInstances.Count;

            if (length != 0)
            {
                PointData[] data = new PointData[length];

                Parallel.For(0, length, i =>
                    {
                        var instance = tempInstances[i];

                        var matrix = Matrix4.Identity;

                        data[i] = new PointData()
                        {
                            Color = instance.Color,
                            Position = instance.P
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
