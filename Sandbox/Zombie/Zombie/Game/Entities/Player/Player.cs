using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Entities.Components;
using Zombie.Sprites;

namespace Zombie.Entities
{
    public class Player : Entity, ILocated, IUpdatable, IRenderable
    {
        private readonly LocationComponent m_location;
        private readonly RigidBodyComponent m_rigidBody;

        private readonly SpriteRenderer m_renderer;
        private readonly ISpriteInstance m_sprite;

        private readonly SpriteSequence m_walkRightSequence;
        private readonly SpriteSequence m_walkLeftSequence;
        private readonly SpriteSequence m_walkFrontSequence;
        private readonly SpriteSequence m_walkBackSequence;

        private SpriteSequence m_currentSequence;
        private bool m_down;

        public Box2 Location { get { return m_location.Location; } }
        public RigidBodyComponent RigidBody { get { return m_rigidBody; } }

        public Player()
        {
            m_location = new LocationComponent(this);
            m_rigidBody = new RigidBodyComponent(this, m_location);

            m_renderer = new SpriteRenderer(PlayerSprites.Instance);
            m_sprite = m_renderer.AddSprite(PlayerSprites.Instance.Front1);

            m_walkRightSequence = new SpriteSequence(
                PlayerSprites.Instance.Right1,
                PlayerSprites.Instance.Right2,
                PlayerSprites.Instance.Right3
            );

            m_walkRightSequence = new SpriteSequence(
               PlayerSprites.Instance.Left1,
               PlayerSprites.Instance.Left2,
               PlayerSprites.Instance.Left3
           );

           m_walkFrontSequence = new SpriteSequence(
               PlayerSprites.Instance.Front1,
               PlayerSprites.Instance.Front2,
               PlayerSprites.Instance.Front3
           );

           m_walkBackSequence = new SpriteSequence(
               PlayerSprites.Instance.Back1,
               PlayerSprites.Instance.Back2,
               PlayerSprites.Instance.Back3
           );
        }

        private SpriteSequence GetSpriteSequence()
        {
            SpriteSequence seq = null; 

            if (Math.Abs(m_rigidBody.Velocity.X) > Math.Abs(m_rigidBody.Velocity.Y))
            {
                if (m_rigidBody.Velocity.X > 0)
                {
                    seq = m_walkRightSequence;
                }
                else
                {
                    seq = m_walkLeftSequence;
                }
            }
            else
            {
                if (m_rigidBody.Velocity.Y > 0)
                {
                    seq = m_walkBackSequence;
                }
                else
                {
                    seq = m_walkFrontSequence;
                }
            }

            return seq;
        }

        public void SetPosition(Vector2 position)
        {
            m_location.Location = new Box2(position, new Vector2(70, 70));
        }

        public void Update(TimeSpan elapsed)
        {
            m_rigidBody.Update(elapsed);

            m_down = m_rigidBody.Grounded && Engine.Keyboard.IsKeyPressed(Key.Down);

            var sequence = GetSpriteSequence();

            if (sequence != m_currentSequence)
            {
                m_currentSequence = sequence;
                m_currentSequence.Reset();
            }

            m_currentSequence.Update(elapsed);
        }

        public void Render(Matrix4 transform)
        {
            m_sprite.Position = m_location.Location.Position;
            m_sprite.Sprite = m_currentSequence.CurrentSprite;
            m_sprite.Size = new Vector2(m_sprite.Sprite.Size.X, m_sprite.Sprite.Size.Y);
            m_renderer.Render(transform);
        }
    }
}
