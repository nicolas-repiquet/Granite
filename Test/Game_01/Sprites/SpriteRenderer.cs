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
        private struct SpriteVertex
        {
            public Vector2d Position;
            public Vector2d TextureCoordinates;
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

            private Vector2d m_position;
            public Vector2d Position
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

            private Vector2d m_size;
            public Vector2d Size
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
        private readonly Buffer<SpriteVertex> m_buffer;
        private readonly IBufferView m_positionView;
        private readonly IBufferView m_textureCoordinatesView;

        public SpriteSheet SpriteSheet { get; private set; }

        private bool m_isDirty;

        public SpriteRenderer(SpriteSheet spriteSheet)
        {
            m_program = SpriteProgram.Instance;
            
            m_instances = new List<SpriteInstance>();
            m_buffer = new Buffer<SpriteVertex>();

            m_positionView = m_buffer.GetView("Position");
            m_textureCoordinatesView = m_buffer.GetView("TextureCoordinates");

            SpriteSheet = spriteSheet;

            m_isDirty = true;
        }

        public ISpriteInstance AddSprite(Sprite sprite)
        {
            Contract.Requires(sprite != null && sprite.SpriteSheet == SpriteSheet);

            var instance = new SpriteInstance(this, sprite);
            m_instances.Add(instance);

            instance.Size = new Vector2d(sprite.Size.X, sprite.Size.Y);

            return instance;
        }

        public void Render(Matrix4 transform)
        {
            if (m_isDirty)
            {
                RebuildBuffer();
            }

            GL.UseProgram(m_program);

            m_program.Position.SetValue(m_positionView);
            m_program.TextureCoordinates.SetValue(m_textureCoordinatesView);
            m_program.Transform.SetValue(transform);
            m_program.Texture.SetValue(SpriteSheet.Texture);

            GL.DrawArrays(GL.TRIANGLES, 0, m_buffer.Count);

            GL.UseProgram(null);
        }

        private void RebuildBuffer()
        {
            var vertices = new List<SpriteVertex>(m_instances.Count * 6);

            foreach (var instance in m_instances)
            {
                var sprite = instance.Sprite;

                var p0 = new SpriteVertex()
                {
                    Position = new Vector2d(instance.Position.X, instance.Position.Y),
                    TextureCoordinates = new Vector2d(sprite.Coordinates.MinX, sprite.Coordinates.MaxY)
                };

                var p1 = new SpriteVertex()
                {
                    Position = new Vector2d(instance.Position.X + instance.Size.X, instance.Position.Y),
                    TextureCoordinates = new Vector2d(sprite.Coordinates.MaxX, sprite.Coordinates.MaxY)
                };

                var p2 = new SpriteVertex()
                {
                    Position = new Vector2d(instance.Position.X + instance.Size.X, instance.Position.Y + instance.Size.Y),
                    TextureCoordinates = new Vector2d(sprite.Coordinates.MaxX, sprite.Coordinates.MinY)
                };

                var p3 = new SpriteVertex()
                {
                    Position = new Vector2d(instance.Position.X, instance.Position.Y + instance.Size.Y),
                    TextureCoordinates = new Vector2d(sprite.Coordinates.MinX, sprite.Coordinates.MinY)
                };

                vertices.Add(p0);
                vertices.Add(p1);
                vertices.Add(p2);

                vertices.Add(p2);
                vertices.Add(p3);
                vertices.Add(p0);
            }

            m_buffer.SetData(vertices.ToArray());

            m_isDirty = false;
        }
    }
}
