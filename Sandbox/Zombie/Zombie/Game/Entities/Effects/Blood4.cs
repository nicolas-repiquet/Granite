using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Effects
{
    public class Blood4 : Blood
    {
        private readonly SpriteSequence m_sequence;

        public Blood4()
        {
            m_sequence = new SpriteSequence(
                BloodSprites.Instance.Blood30,
                BloodSprites.Instance.Blood31,
                BloodSprites.Instance.Blood32,
                BloodSprites.Instance.Blood33,
                BloodSprites.Instance.Blood34,
                BloodSprites.Instance.Blood35
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
