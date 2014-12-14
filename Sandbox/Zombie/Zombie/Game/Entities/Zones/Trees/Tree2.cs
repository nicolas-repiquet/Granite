using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Zones.Trees
{
    public class Tree2 : Tree
    {
        private readonly SpriteSequence m_sequence;

        public Tree2()
        {
            m_sequence = new SpriteSequence(
                TreesSprites.Instance.Arbre11
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

        public void SetPosition(Vector2 position)
        {
            m_location.SetPosition(position);
            m_box = new Vector2(64, 96);
        }

        public override void SetSprite(SpriteRenderer renderer)
        {
            m_sprite = renderer.AddSprite(TreesSprites.Instance.Arbre11);

            UpdateSprite(TimeSpan.Zero, GetSpriteSequence());
        }

        public override void Update(TimeSpan elapsed)
        {
            base.Update(elapsed);

        }
    }
}
