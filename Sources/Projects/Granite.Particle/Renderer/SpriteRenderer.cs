using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Granite.Particle.Shaders;

namespace Granite.Particle.Renderer
{
    public sealed class SpriteRenderer
    {
        private struct SpriteData
        {
            public Color4ub Color;
            public Matrix4 Transform;
            public Vector2 TextureOrigin;
            public Vector2 TextureTarget;
            public float Progress;
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

            private Vector2 m_position;
            public Vector2 Position
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

            private Vector2 m_size;
            public Vector2 Size
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

            private float m_angle;
            public float Angle
            {
                get { return m_angle; }
                set
                {
                    if (m_angle != value)
                    {
                        m_angle = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }

            private float m_progress;
            public float Progress
            {
                get { return m_progress; }
                set
                {
                    if (m_progress != value)
                    {
                        m_progress = value;
                        m_renderer.m_isDirty = true;
                    }
                }
            }
        }

        private readonly SpriteProgram m_program;
        private readonly List<SpriteInstance> m_instances;
        private readonly Buffer<SpriteData> m_bufferSprite;
        private readonly Buffer<Vector3> m_bufferQuad;
        private readonly VertexArray m_vao;

        public SpriteSheet SpriteSheet { get; private set; }
        public Texture2D textureFire { get; private set; }

        private bool m_isDirty;

        public SpriteRenderer(SpriteSheet spriteSheet)
        {
            SpriteSheet = spriteSheet;
            textureFire = Texture2D.Load(typeof(Particle).Assembly.GetManifestResourceStream("Granite.Particle.Textures.fire_color.png"));

            m_program = SpriteProgram.Instance;
            m_instances = new List<SpriteInstance>();
            m_vao = new VertexArray();

            GL.BindVertexArray(m_vao);

            m_bufferSprite = new Buffer<SpriteData>();
            m_bufferQuad = new Buffer<Vector3>();
           

            m_bufferQuad.SetData(new Vector3[] {
                new Vector3(0f, 0f, 0f),
                new Vector3(0f, 1f, 0f),
                new Vector3(1f, 1f, 0f),
                new Vector3(1f, 0f, 0f)
            });

            
            GL.UseProgram(m_program);

            m_program.Position.SetValue(m_bufferQuad.GetView());

            //m_program.Color.SetValue(m_bufferSprite.GetView(s => s.Color));
            //m_program.Color.SetDivisor(1);
            m_program.Transform.SetValue(m_bufferSprite.GetView<Matrix4>("Transform"));
            m_program.Transform.SetDivisor(1);
            m_program.TextureOrigin.SetValue(m_bufferSprite.GetView<Vector2>("TextureOrigin"));
            m_program.TextureOrigin.SetDivisor(1);
            m_program.TextureTarget.SetValue(m_bufferSprite.GetView<Vector2>("TextureTarget"));
            m_program.TextureTarget.SetDivisor(1);
            m_program.Progress.SetValue(m_bufferSprite.GetView(s => s.Progress));
            m_program.Progress.SetDivisor(1);

            GL.BindVertexArray(null);

            m_isDirty = true;
        }

        public ISpriteInstance AddSprite(Sprite sprite)
        {
            Contract.Requires(sprite != null && sprite.SpriteSheet == SpriteSheet);

            var instance = new SpriteInstance(this, sprite);
           
            instance.Size = new Vector2(sprite.Size.X, sprite.Size.Y);

            lock (m_instances)
            {
                m_instances.Add(instance);
            }

            return instance;
        }

        public void Clear()
        {
            lock (m_instances)
            {
                m_instances.Clear();
            }
            m_isDirty = true;
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
               
                m_program.Texture2.SetValue(textureFire);
                m_program.Texture.SetValue(SpriteSheet.Texture);

                GL.DrawArraysInstanced(GL.TRIANGLE_FAN, 0, 4, m_instances.Count);

                //GL.BindVertexArray(null);
            }

        }

        private void RebuildBuffer()
        {
            List<SpriteInstance> tempInstances = null;
            lock (m_instances)
            {
                tempInstances = new List<SpriteInstance>(m_instances);
            }

            var length = tempInstances.Count;

            if (length != 0)
            {

                var data = new SpriteData[length];

                Parallel.For(0, length, i =>
                    {
                        var instance = tempInstances[i];
                        var sprite = instance.Sprite;

                        var matrix = Matrix4.Identity;
                        matrix *= Matrix4.Translate(instance.Position.X + instance.Size.X / 2, instance.Position.Y + instance.Size.Y / 2, 0f);
                        matrix *= Matrix4.RotateZ(instance.Angle);
                        matrix *= Matrix4.Translate(- instance.Size.X / 2, - instance.Size.Y / 2, 0f);
                        matrix *= Matrix4.Scale(instance.Size.X, instance.Size.Y, 0f);

                        data[i] = new SpriteData()
                        {
                            Color = instance.Color,
                            Transform = matrix,
                            TextureOrigin = sprite.Coordinates.Position,
                            TextureTarget = sprite.Coordinates.Position + sprite.Coordinates.Size,
                            Progress = instance.Progress
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
