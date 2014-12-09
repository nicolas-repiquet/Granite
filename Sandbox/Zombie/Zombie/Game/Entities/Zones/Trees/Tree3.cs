using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Zones.Trees
{
    public class Tree3 : Tree
    {
        private readonly SpriteSequence m_sequence;

        public Tree3()
        {
            m_sequence = new SpriteSequence(
                TreesSprites.Instance.Arbre3
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
            m_box = new Vector2(128, 128);
        }

        public override void SetSprite(SpriteRenderer renderer)
        {
            m_sprite = renderer.AddSprite(TreesSprites.Instance.Arbre3);
        }

        public override void Update(TimeSpan elapsed)
        {
            base.Update(elapsed);

            var sequence = GetSpriteSequence();

            if (sequence != m_currentSequence)
            {
                m_currentSequence = sequence;
                m_currentSequence.Reset();
            }

            m_currentSequence.Update(elapsed);

            m_sprite.Position = new Vector2(m_location.Position.X - m_box.X / 2, m_location.Position.Y - m_box.Y / 2);
            m_sprite.Sprite = m_currentSequence.CurrentSprite;
            m_sprite.Size = new Vector2(m_sprite.Sprite.Size.X, m_sprite.Sprite.Size.Y);
        }
    }
}
