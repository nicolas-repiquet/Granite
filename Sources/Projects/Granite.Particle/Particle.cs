using Granite.Core;
using Granite.Particle.Renderer;
using Granite.Particle.Textures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Particle
{
    public class Particle
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public float Angle { get; set; }
        public float AngularVelocity { get; set; }
        public Color4ub Color { get; set; }
        public float Size { get; set; }
        public int TTL { get; set; }
        public int TTLMax { get; set; }

        protected ISpriteInstance m_sprite;

        public Particle(Texture2D texture, Vector2 position, Vector2 velocity,
            float angle, float angularVelocity, Color4ub color, float size, int ttl)
        {
            Texture = texture;
            Position = position;
            Velocity = velocity;
            Angle = angle;
            AngularVelocity = angularVelocity;
            Color = color;
            Size = size;
            TTL = ttl;
            TTLMax = ttl;
        }

        public void Update(TimeSpan elapsed)
        {
            TTL = (int)(TTL - elapsed.TotalSeconds);
            Position += Velocity * (float)elapsed.TotalSeconds;
            Angle += AngularVelocity * (float)elapsed.TotalSeconds;

            if (m_sprite != null)
            {
                m_sprite.Position = new Vector2(Position.X - (m_sprite.Sprite.Size.X * Size) / 2, Position.Y - (m_sprite.Sprite.Size.X * Size) / 2);
                m_sprite.Sprite = ParticleTexture.Instance.Sprite;
                m_sprite.Size = new Vector2(m_sprite.Sprite.Size.X * Size, m_sprite.Sprite.Size.Y * Size);
                m_sprite.Color = Color;
                m_sprite.Angle = Angle;
                m_sprite.Progress = 1f - ((float)TTL / (float)TTLMax);
            }
        }

        public void SetSprite(SpriteRenderer renderer)
        {
            m_sprite = renderer.AddSprite(ParticleTexture.Instance.Sprite);
        }
    }
}
