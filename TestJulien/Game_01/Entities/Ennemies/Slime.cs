using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestJulien.Game_01.Sprites;

namespace TestJulien.Game_01.Entities.Ennemies
{
    public class Slime : Ennemy
    {

        private readonly SpriteSequence m_idleLeftSequence;
        private readonly SpriteSequence m_idleRightSequence;
        private readonly SpriteSequence m_walkLeftSequence;
        private readonly SpriteSequence m_walkRightSequence;
        private readonly SpriteSequence m_deadSequence;

       

        public Slime()
        {
            m_idleLeftSequence = new SpriteSequence(
                EnemiesSprites.Instance.SlimeWalkLeft1
            );

            m_idleRightSequence = new SpriteSequence(
                EnemiesSprites.Instance.SlimeWalkRight1
            );

            m_walkLeftSequence = new SpriteSequence(
                EnemiesSprites.Instance.SlimeWalkLeft1,
                EnemiesSprites.Instance.SlimeWalkLeft2
            );

            m_walkRightSequence = new SpriteSequence(
                EnemiesSprites.Instance.SlimeWalkRight1,
                EnemiesSprites.Instance.SlimeWalkRight2
            );

            m_walkLeftSequence.SpritesPerSecond = 6;
            m_walkRightSequence.SpritesPerSecond = 6;

            m_deadSequence = new SpriteSequence(
                EnemiesSprites.Instance.SlimeDead
            );
        }

        private SpriteSequence GetSpriteSequence()
        {
            if (Math.Abs(m_rigidBody.Velocity.X) < 10)
            {
                if (m_currentSequence == m_idleRightSequence ||
                    m_currentSequence == m_walkRightSequence)
                {
                    return m_idleRightSequence;

                }
                else
                {
                    return m_idleLeftSequence;
                }
            }
            if (m_rigidBody.Velocity.X > 0)
            {
                return m_walkRightSequence;
            }
            else
            {
                return m_walkLeftSequence;

            }     
        }

        public void SetPosition(Vector2 position)
        {
            m_location.Location = new Box2(position, new Vector2(50, 32));
        }

        public override void SetSprite(SpriteRenderer renderer)
        {
            m_sprite = renderer.AddSprite(EnemiesSprites.Instance.SlimeWalkRight1);
        }

        public override void Update(TimeSpan elapsed)
        {
            if (m_target != null)
            {
                var direction = new Vector2(
                    m_target.Location.Center.X - m_location.Location.Position.X,
                    m_target.Location.Center.Y - m_location.Location.Position.Y
                    );
                m_rigidBody.Direction = direction;

                if (m_rigidBody.Grounded)
                {
                    m_rigidBody.Velocity += new Vector2(0, 550);
                }
            }

            m_rigidBody.Update(elapsed);

            var sequence = GetSpriteSequence();

            if (sequence != m_currentSequence)
            {
                m_currentSequence = sequence;
                m_currentSequence.Reset();
            }

            m_currentSequence.Update(elapsed);

            m_sprite.Position = m_location.Location.Position;
            m_sprite.Sprite = m_currentSequence.CurrentSprite;
            m_sprite.Size = new Vector2(m_sprite.Sprite.Size.X, m_sprite.Sprite.Size.Y);
        }

        //public override void Render(Matrix4 transform)
        //{

        //}
    }
}
