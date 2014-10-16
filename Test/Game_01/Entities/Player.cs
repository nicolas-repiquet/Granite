using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Entities
{
    public class Player : Entity, ILocated, IUpdatable, IRenderable
    {
        private readonly Sprite[] m_spriteSequence;
        private readonly LocationComponent m_location;
        private readonly RigidBodyComponent m_rigidBody;

        private readonly SpriteRenderer m_renderer;
        private readonly ISpriteInstance m_sprite;

        public Box2 Location { get { return m_location.Location; } }

        public Player()
        {
            m_location = new LocationComponent(this);
            m_rigidBody = new RigidBodyComponent(this, m_location);

            m_renderer = new SpriteRenderer(PlayerSprites.Instance);
            m_sprite = m_renderer.AddSprite(PlayerSprites.Instance.Stand);

            m_spriteSequence = new Sprite[] {
                PlayerSprites.Instance.Walk01,
                PlayerSprites.Instance.Walk02,
                PlayerSprites.Instance.Walk03,
                PlayerSprites.Instance.Walk04,
                PlayerSprites.Instance.Walk05,
                PlayerSprites.Instance.Walk06,
                PlayerSprites.Instance.Walk07,
                PlayerSprites.Instance.Walk08,
                PlayerSprites.Instance.Walk09,
                PlayerSprites.Instance.Walk10,
                PlayerSprites.Instance.Walk11
            };
        }

        public void SetPosition(Vector2 position)
        {
            m_location.Location = new Box2(position, new Vector2(70, 70));
        }

        public void Jump()
        {
            if (m_rigidBody.Grounded)
            {
                m_rigidBody.Velocity += new Vector2(0, 350);
                m_rigidBody.Grounded = false;
            }
        }

        public void MoveLeft()
        {
            m_rigidBody.Velocity += new Vector2(-2, 0);
        }

        public void MoveRight()
        {
            m_rigidBody.Velocity += new Vector2(2, 0);
        }

        double m_time = 0;

        public void Update(TimeSpan elapsed)
        {
            m_time += elapsed.TotalSeconds;
            m_sprite.Sprite = m_spriteSequence[(int)(m_time * m_spriteSequence.Length) % m_spriteSequence.Length];
            m_rigidBody.Update(elapsed);
        }

        public void Render(Matrix4 transform)
        {
            m_sprite.Position = m_location.Location.Position;
            m_renderer.Render(transform);
        }
    }
}
