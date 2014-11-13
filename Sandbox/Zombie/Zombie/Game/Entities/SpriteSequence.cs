using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Entities.Components;
using Zombie.Sprites;

namespace Zombie.Entities
{
    public sealed class SpriteSequence : IUpdatable
    {
        public double SpritesPerSecond { get; set;}
        private readonly Sprite[] m_sprites;
        private double m_time;

        public SpriteSequence(params Sprite[] sprites)
        {
            m_sprites = sprites;
            SpritesPerSecond = 15;
        }

        public void Update(TimeSpan elapsed)
        {
            m_time += elapsed.TotalSeconds;

        }

        public void Reset()
        {
            m_time = 0;
        }

        public Sprite CurrentSprite
        {
            get
            {
                return m_sprites[(int)(m_time * SpritesPerSecond) % m_sprites.Length];
            }
        }

    }
}
