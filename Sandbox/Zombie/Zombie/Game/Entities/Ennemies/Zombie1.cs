using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Ennemies
{
    public class Zombie1 : Ennemy
    {
        private readonly SpriteSequence m_walkRightSequence;
        private readonly SpriteSequence m_walkLeftSequence;
        private readonly SpriteSequence m_walkFrontSequence;
        private readonly SpriteSequence m_walkBackSequence;

        public Zombie1()
        {
            m_walkRightSequence = new SpriteSequence(
                EnnemiesSprites.Instance.Right1,
                EnnemiesSprites.Instance.Right2,
                EnnemiesSprites.Instance.Right3
            );

            m_walkLeftSequence = new SpriteSequence(
               EnnemiesSprites.Instance.Left1,
               EnnemiesSprites.Instance.Left2,
               EnnemiesSprites.Instance.Left3
           );

            m_walkFrontSequence = new SpriteSequence(
                EnnemiesSprites.Instance.Front1,
                EnnemiesSprites.Instance.Front2,
                EnnemiesSprites.Instance.Front3
            );

            m_walkBackSequence = new SpriteSequence(
                EnnemiesSprites.Instance.Back1,
                EnnemiesSprites.Instance.Back2,
                EnnemiesSprites.Instance.Back3
            );

            m_move.Speed = 10;
        }

        private SpriteSequence GetSpriteSequence()
        {
            SpriteSequence seq = null;

            if (Math.Abs(m_move.LastDirection.X) > Math.Abs(m_move.LastDirection.Y))
            {
                if (m_move.LastDirection.X > 0)
                {
                    seq = m_walkRightSequence;
                }
                else if (m_move.LastDirection.X < 0)
                {
                    seq = m_walkLeftSequence;
                }
            }
            else
            {
                if (m_move.LastDirection.Y > 0)
                {
                    seq = m_walkBackSequence;
                }
                else if (m_move.LastDirection.Y < 0)
                {
                    seq = m_walkFrontSequence;
                }
            }

            if (seq == null)
            {
                seq = m_walkFrontSequence;
            }

            return seq;
        }

        public void SetPosition(Vector2 position)
        {
            m_location.SetPosition(position);
            m_box = new Vector2(23, 23);
        }

        public override void SetSprite(SpriteRenderer renderer)
        {
            m_sprite = renderer.AddSprite(EnnemiesSprites.Instance.Front1);
        }

        public override void Update(TimeSpan elapsed)
        {
            if (m_target != null)
            {
                var direction = new Vector2(
                    m_target.Location.Position.X - m_location.Position.X,
                    m_target.Location.Position.Y - m_location.Position.Y
                    );
                m_move.Direction = direction;
            }

            base.Update(elapsed);

            //m_rigidBody.Update(elapsed);

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
