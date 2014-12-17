using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Effects
{
    public class Blood2 : Blood
    {
        private readonly SpriteSequence m_sequence;

        public Blood2()
        {
            m_sequence = new SpriteSequence(
                BloodSprites.Instance.Blood10,
                BloodSprites.Instance.Blood11,
                BloodSprites.Instance.Blood12,
                BloodSprites.Instance.Blood13,
                BloodSprites.Instance.Blood14,
                BloodSprites.Instance.Blood15
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
