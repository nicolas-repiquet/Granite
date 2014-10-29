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
            public Vector2 TextureOrigin;
            public Vector2 TextureTarget;
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
        }

        private readonly SpriteProgram m_program;
        private readonly List<SpriteInstance> m_instances;
        private readonly Buffer<SpriteData> m_bufferSprite;
        private readonly Buffer<Vector3> m_bufferQuad;
        private readonly VertexArray m_vao;

        public SpriteSheet SpriteSheet { get; private set; }

        private bool m_isDirty;

        public SpriteRenderer(SpriteSheet spriteSheet)
        {
            SpriteSheet = spriteSheet;

            m_program = SpriteProgram.Instance;
            m_instances = new List<SpriteInstance>();
            m_bufferSprite = new Buffer<SpriteData>();
            m_bufferQuad = new Buffer<Vector3>();
            m_vao = new VertexArray();

            m_bufferQuad.SetData(new Vector3[] {
                new Vector3(0f, 0f, 0f),
                new Vector3(0f, 1f, 0f),
                new Vector3(1f, 1f, 0f),
                new Vector3(1f, 0f, 0f)
            });

            GL.BindVertexArray(m_vao);
            GL.UseProgram(m_program);

            m_program.Position.SetValue(m_bufferQuad.GetView());

            m_program.Transform.SetValue(m_bufferSprite.GetView<Matrix4>("Transform"));
            m_program.Transform.SetDivisor(1);
            m_program.TextureOrigin.SetValue(m_bufferSprite.GetView<Vector2>("TextureOrigin"));
            m_program.TextureOrigin.SetDivisor(1);
            m_program.TextureTarget.SetValue(m_bufferSprite.GetView<Vector2>("TextureTarget"));
            m_program.TextureTarget.SetDivisor(1);

            GL.BindVertexArray(null);

            m_isDirty = true;
        }

        public ISpriteInstance AddSprite(Sprite sprite)
        {
            Contract.Requires(sprite != null && sprite.SpriteSheet == SpriteSheet);

            var instance = new SpriteInstance(this, sprite);
            m_instances.Add(instance);

            instance.Size = new Vector2(sprite.Size.X, sprite.Size.Y);

            return instance;
        }

        public void Render(Matrix4 transform)
        {
            if (m_isDirty)
            {
                RebuildBuffer();
            }

            GL.UseProgram(m_program);
            GL.BindVertexArray(m_vao);

            m_program.Projection.SetValue(transform);
            m_program.Texture.SetValue(SpriteSheet.Texture);

            GL.DrawArraysInstanced(GL.TRIANGLE_FAN, 0, 4, m_instances.Count);

            GL.BindVertexArray(null);
        }

        private void RebuildBuffer()
        {
            m_bufferSprite.SetData(m_instances.Count, GL.STREAM_DRAW);

            using (var mapping = m_bufferSprite.Map())
            {
                unsafe
                {
                    SpriteData* data = (SpriteData*)mapping.Address.ToPointer();

                    for (int i = 0; i < m_instances.Count; i++)
                    {
                        var instance = m_instances[i];
                        var sprite = instance.Sprite;

                        var matrix = Matrix4.Identity;
                        matrix *= Matrix4.Translate(instance.Position.X, instance.Position.Y, 0f);
                        matrix *= Matrix4.Scale(instance.Size.X, instance.Size.Y, 0f);

                        data[i] = new SpriteData()
                        {
                            Color = new Vector4(1f, 1f, 1f, 1f),
                            Transform = matrix,
                            TextureOrigin = sprite.Coordinates.Position,
                            TextureTarget = sprite.Coordinates.Position + sprite.Coordinates.Size
                        };
                    }
                }

            }

            m_isDirty = false;
        }
    }
}
