using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Test.Game_01.Shaders;
using Test.Game_01.Sprites;
using Test.Game_02.Shaders;

namespace Test.Game_02
{
    public sealed class GeodeRenderer
    {
        private struct TriangleData
        {
            public Vector4 Color;
            public Matrix4 Transform;
            public Vector3 Normal;
            public Vector3 Position;
            public Vector2 TextureOrigin;
            public Vector2 TextureTarget;
        }

        private sealed class TriangleInstance : ITriangleInstance
        {

            private readonly GeodeRenderer m_renderer;

            public TriangleInstance(GeodeRenderer renderer)
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

        public GeodeRenderer()
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
            m_program.Normal.SetValue(m_bufferSprite.GetView<Vector3>("Normal"));
           // m_program.Normal.SetDivisor(1);
            m_program.Transform.SetValue(m_bufferSprite.GetView<Matrix4>("Transform"));
            //m_program.Transform.SetDivisor(1);
            m_program.TextureOrigin.SetValue(m_bufferSprite.GetView<Vector2>("TextureOrigin"));
            //m_program.TextureOrigin.SetDivisor(1);
            m_program.TextureTarget.SetValue(m_bufferSprite.GetView<Vector2>("TextureTarget"));
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
            //m_bufferSprite.SetData(m_instances.Count*3, GL.STREAM_DRAW);

            TriangleData[] data = new TriangleData[m_instances.Count*3];

            for (int i = 0; i < m_instances.Count*3; i=i+3)
            {
                var instance = m_instances[i/3];

                //var center = Barycentre(instance, 1, 1, 1);

                var matrix = Matrix4.Identity;
                //matrix *= Matrix4.Translate(instance.P1.X, instance.P1.Y, instance.P1.Z);

                var u = new Vector3(
                    instance.P2.X - instance.P1.X,
                    instance.P2.Y - instance.P1.Y,
                    instance.P2.Z - instance.P1.Z
                    );

                var v = new Vector3(
                    instance.P3.X - instance.P1.X,
                    instance.P3.Y - instance.P1.Y,
                    instance.P3.Z - instance.P1.Z
                    );

                var normal = new Vector3(
                    u.Y * v.Z - v.Y * u.Z,
                    -(u.X * v.Z - v.X * u.Z),
                    u.X * v.Y - v.X * u.Y);

                data[i] = new TriangleData()
                {
                    Color = instance.Color,
                    Transform = matrix,
                    Normal = normal,
                    Position = instance.P1
                };

                data[i+1] = new TriangleData()
                {
                    Color = instance.Color,
                    Transform = matrix,
                    Normal = normal,
                    Position = instance.P2
                };

                data[i+2] = new TriangleData()
                {
                    Color = instance.Color,
                    Transform = matrix,
                    Normal = normal,
                    Position = instance.P3
                };
            }

            m_bufferSprite.SetData(data, GL.STREAM_DRAW);

            //using (var mapping = m_bufferSprite.Map())
            //{
            //    unsafe
            //    {
            //        TriangleData* data = (TriangleData*)mapping.Address.ToPointer();

            //        for (int i = 0; i < m_instances.Count*3; i=i+3)
            //        {
            //            var instance = m_instances[i/3];

            //            //var center = Barycentre(instance, 1, 1, 1);

            //            var matrix = Matrix4.Identity;
            //            //matrix *= Matrix4.Translate(instance.P1.X, instance.P1.Y, instance.P1.Z);

            //            var u = new Vector3(
            //                instance.P2.X - instance.P1.X,
            //                instance.P2.Y - instance.P1.Y,
            //                instance.P2.Z - instance.P1.Z
            //                );

            //            var v = new Vector3(
            //                instance.P3.X - instance.P1.X,
            //                instance.P3.Y - instance.P1.Y,
            //                instance.P3.Z - instance.P1.Z
            //                );

            //            var normal = new Vector3(
            //                u.Y * v.Z - v.Y * u.Z,
            //                -(u.X * v.Z - v.X * u.Z),
            //                u.X * v.Y - v.X * u.Y);

            //            data[i] = new TriangleData()
            //            {
            //                Color = new Vector4(1f, 1f, 1f, 1f),
            //                Transform = matrix,
            //                Normal = normal,
            //                Position = instance.P1
            //            };

            //            data[i+1] = new TriangleData()
            //            {
            //                Color = new Vector4(1f, 1f, 1f, 1f),
            //                Transform = matrix,
            //                Normal = normal,
            //                Position = instance.P2
            //            };

            //            data[i+2] = new TriangleData()
            //            {
            //                Color = new Vector4(1f, 1f, 1f, 1f),
            //                Transform = matrix,
            //                Normal = normal,
            //                Position = instance.P3
            //            };
            //        }
            //    }

            //}

            m_isDirty = false;
        }

        
    }
}
