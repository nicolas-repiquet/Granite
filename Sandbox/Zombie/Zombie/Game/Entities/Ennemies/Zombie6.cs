using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Ennemies
{
    public class Zombie6 : Ennemy
    {
        private readonly SpriteSequence m_walkRightSequence;
        private readonly SpriteSequence m_walkLeftSequence;
        private readonly SpriteSequence m_walkFrontSequence;
        private readonly SpriteSequence m_walkBackSequence;

        public Zombie6()
        {
            m_walkRightSequence = new SpriteSequence(
                EnnemiesSprites.Instance.Z6Right1,
                EnnemiesSprites.Instance.Z6Right2,
                EnnemiesSprites.Instance.Z6Right3
            );

            m_walkLeftSequence = new SpriteSequence(
               EnnemiesSprites.Instance.Z6Left1,
               EnnemiesSprites.Instance.Z6Left2,
               EnnemiesSprites.Instance.Z6Left3
           );

            m_walkFrontSequence = new SpriteSequence(
                EnnemiesSprites.Instance.Z6Front1,
                EnnemiesSprites.Instance.Z6Front2,
                EnnemiesSprites.Instance.Z6Front3
            );

            m_walkBackSequence = new SpriteSequence(
                EnnemiesSprites.Instance.Z6Back1,
                EnnemiesSprites.Instance.Z6Back2,
                EnnemiesSprites.Instance.Z6Back3
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

        //public override void SetPosition(Vector2 position)
        //{
        //    m_location.SetPosition(position);
        //    m_box = new Vector2(24, 27);
        //}

        public override void SetSprite(SpriteRenderer renderer)
        {
            m_sprite = renderer.AddSprite(EnnemiesSprites.Instance.Z6Front1);
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
            m_sprite.Size = new Vector2(m_box.X, m_box.Y);
        }
    }
}
