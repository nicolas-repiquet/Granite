using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Zombie.Game.Shaders;

namespace Zombie.Game.Entities.Tools
{
    public sealed class SegmentRenderer
    {
        private struct SegmentData
        {
            public Color4ub Color;
            public Vector3 Position;
        }

        private sealed class SegmentInstance : ISegmentInstance
        {

            private readonly SegmentRenderer m_renderer;

            public SegmentInstance(SegmentRenderer renderer)
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
        }

        private readonly TriangleProgram m_program;
        private readonly List<SegmentInstance> m_instances;
        private readonly Buffer<SegmentData> m_bufferSprite;
        private readonly Buffer<Vector3> m_bufferTriangle;
        private readonly VertexArray m_vao;

        private bool m_isDirty;

        public SegmentRenderer()
        {
            m_program = TriangleProgram.Instance;
            m_instances = new List<SegmentInstance>();
            
            
            m_vao = new VertexArray();

            GL.BindVertexArray(m_vao);
            GL.UseProgram(m_program);

            m_bufferSprite = new Buffer<SegmentData>();
            m_bufferTriangle = new Buffer<Vector3>();

            m_program.Position.SetValue(m_bufferSprite.GetView<Vector3>("Position"));

            m_program.Color.SetValue(m_bufferSprite.GetView<Color4ub>("Color"));
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
            lock (m_instances)
            {
                m_instances.Clear();
            }
        }

        public ISegmentInstance AddSegment(Segment segment)
        {
            var instance = new SegmentInstance(this);
            lock (m_instances)
            {
                m_instances.Add(instance);
            }

            instance.P1 = new Vector3(segment.P1.X, segment.P1.Y, 0);
            instance.P2 = new Vector3(segment.P2.X, segment.P2.Y, 0);
            instance.Color = segment.Color;

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

            GL.DrawArrays(GL.LINES, 0, m_instances.Count * 2);

            GL.BindVertexArray(null);
        }

        private void RebuildBuffer()
        {
            List<SegmentInstance> tempInstances = null;
            lock (m_instances)
            {
                tempInstances = new List<SegmentInstance>(m_instances);
            }

            var length = tempInstances.Count;

            if (length != 0)
            {
                SegmentData[] data = new SegmentData[length * 2];

                for (int i = 0; i < length * 2; i = i + 2)
                {
                    var instance = tempInstances.ElementAt(i / 2);

                    var matrix = Matrix4.Identity;

                    data[i] = new SegmentData()
                    {
                        Color = instance.Color,
                        Position = instance.P1
                    };

                    data[i + 1] = new SegmentData()
                    {
                        Color = instance.Color,
                        Position = instance.P2
                    };
                }

                m_bufferSprite.SetData(data, GL.STREAM_DRAW);

            }
            
            m_isDirty = false;
        }
    }
}
