using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestJulien.Game_01.Sprites;

namespace TestJulien.Game_01.Entities
{
    public class Player : Entity, ILocated, IUpdatable, IRenderable
    {
        private readonly LocationComponent m_location;
        private readonly RigidBodyComponent m_rigidBody;

        private readonly SpriteRenderer m_renderer;
        private readonly ISpriteInstance m_sprite;

        private readonly SpriteSequence m_walkRightSequence;
        private readonly SpriteSequence m_walkLeftSequence;
        private readonly SpriteSequence m_standRightSequence;
        private readonly SpriteSequence m_standLeftSequence;
        private readonly SpriteSequence m_jumpRightSequence;
        private readonly SpriteSequence m_jumpLeftSequence;
        private readonly SpriteSequence m_duckRightSequence;
        private readonly SpriteSequence m_duckLeftSequence;

        private SpriteSequence m_currentSequence;
        private bool m_down;

        public Box2 Location { get { return m_location.Location; } }
        public RigidBodyComponent RigidBody { get { return m_rigidBody; } }

        public Player()
        {
            m_location = new LocationComponent(this);
            m_rigidBody = new RigidBodyComponent(this, m_location);

            m_renderer = new SpriteRenderer(PlayerSprites.Instance);
            m_sprite = m_renderer.AddSprite(PlayerSprites.Instance.StandRight);

            m_walkRightSequence = new SpriteSequence(
                PlayerSprites.Instance.WalkRight01,
                PlayerSprites.Instance.WalkRight02,
                PlayerSprites.Instance.WalkRight03,
                PlayerSprites.Instance.WalkRight04,
                PlayerSprites.Instance.WalkRight05,
                PlayerSprites.Instance.WalkRight06,
                PlayerSprites.Instance.WalkRight07,
                PlayerSprites.Instance.WalkRight08,
                PlayerSprites.Instance.WalkRight09,
                PlayerSprites.Instance.WalkRight10,
                PlayerSprites.Instance.WalkRight11
            );

            m_walkLeftSequence = new SpriteSequence(
                PlayerSprites.Instance.WalkLeft01,
                PlayerSprites.Instance.WalkLeft02,
                PlayerSprites.Instance.WalkLeft03,
                PlayerSprites.Instance.WalkLeft04,
                PlayerSprites.Instance.WalkLeft05,
                PlayerSprites.Instance.WalkLeft06,
                PlayerSprites.Instance.WalkLeft07,
                PlayerSprites.Instance.WalkLeft08,
                PlayerSprites.Instance.WalkLeft09,
                PlayerSprites.Instance.WalkLeft10,
                PlayerSprites.Instance.WalkLeft11
            );

            m_standRightSequence = new SpriteSequence(PlayerSprites.Instance.StandRight);
            m_standLeftSequence = new SpriteSequence(PlayerSprites.Instance.StandLeft);
            m_jumpRightSequence = new SpriteSequence(PlayerSprites.Instance.JumpRight);
            m_jumpLeftSequence = new SpriteSequence(PlayerSprites.Instance.JumpLeft);
            m_duckRightSequence = new SpriteSequence(PlayerSprites.Instance.DuckRight);
            m_duckLeftSequence = new SpriteSequence(PlayerSprites.Instance.DuckLeft);
        }

        private SpriteSequence GetSpriteSequence()
        {
            if (Math.Abs(m_rigidBody.Velocity.X) < 10)
            {
                if (m_currentSequence == m_standRightSequence ||
                    m_currentSequence == m_walkRightSequence ||
                    m_currentSequence == m_jumpRightSequence ||
                    m_currentSequence == m_duckRightSequence)
                {
                    if (m_rigidBody.Grounded)
                    {
                        if (m_down)
                        {
                            return m_duckRightSequence;
                        }
                        else
                        {
                            return m_standRightSequence;
                        }
                    }
                    else
                    {
                        return m_jumpRightSequence;
                    }
                }
                else
                {
                    if (m_rigidBody.Grounded)
                    {
                        if (m_down)
                        {
                            return m_duckLeftSequence;
                        }
                        else
                        {
                            return m_standLeftSequence;
                        }
                    }
                    else
                    {
                        return m_jumpLeftSequence;
                    }
                }
            }
            if (m_rigidBody.Velocity.X > 0)
            {
                if (m_rigidBody.Grounded)
                {
                    return m_walkRightSequence;
                }
                else
                {
                    return m_jumpRightSequence;
                }
            }
            else
            {
                if (m_rigidBody.Grounded)
                {
                    return m_walkLeftSequence;
                }
                else
                {
                    return m_jumpLeftSequence;
                }
            }
        }

        public void SetPosition(Vector2 position)
        {
            m_location.Location = new Box2(position, new Vector2(70, 70));
        }

        public void Jump()
        {
            if (m_rigidBody.Grounded)
            {
                //m_rigidBody.Velocity += new Vector2(0, 550);
                //m_rigidBody.Grounded = false;
            }
        }

        public void MoveLeft()
        {
            //m_rigidBody.Velocity += new Vector2(-2, 0);
        }

        public void MoveRight()
        {
            //m_rigidBody.Velocity += new Vector2(2, 0);
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
