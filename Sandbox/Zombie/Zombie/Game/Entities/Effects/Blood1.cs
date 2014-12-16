using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Effects
{
    public class Blood1 : Blood
    {
        private readonly SpriteSequence m_sequence;

        public Blood1()
        {
            m_sequence = new SpriteSequence(
                BloodSprites.Instance.Blood00,
                BloodSprites.Instance.Blood01,
                BloodSprites.Instance.Blood02,
                BloodSprites.Instance.Blood03,
                BloodSprites.Instance.Blood04,
                BloodSprites.Instance.Blood05
            );

            m_sequence.SpritesPerSecond = 12;
        }

        private SpriteSequence GetSpriteSequence()
        {
            SpriteSequence seq = null;

            if (seq == null)
            {
                seq = m_sequence;
            }

            return seq;
        }

        public override void SetSprite(SpriteRenderer renderer)
        {
            m_sprite = renderer.AddSprite(TreesSprites.Instance.Arbre20);

            UpdateSprite(TimeSpan.Zero, GetSpriteSequence());
        }

        public override void Update(TimeSpan elapsed)
        {
            base.Update(elapsed);

            UpdateSprite(elapsed, GetSpriteSequence());
        }

        
    }
}
