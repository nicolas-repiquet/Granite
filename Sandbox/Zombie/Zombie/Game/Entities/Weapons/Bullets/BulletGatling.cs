using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Weapons.Bullets
{
    public class BulletGatling : Bullet
    {
        private readonly SpriteSequence m_sequence;

        public BulletGatling()
        {
            m_sequence = new SpriteSequence(
                BulletSprites.Instance.Bullet0
            );
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
            m_sprite = renderer.AddSprite(BulletSprites.Instance.Bullet0);

            UpdateSprite(TimeSpan.Zero, GetSpriteSequence());
        }

        public override void Update(TimeSpan elapsed)
        {
            base.Update(elapsed);

            UpdateSprite(elapsed, GetSpriteSequence());
        }

    }
}
