using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Zones
{
    public class FireCamp : Entity, ILocated, IUpdatable, IRenderable
    {
        protected readonly LocationComponent m_location;
        protected readonly RigidBodyComponent m_rigidBody;
        protected Vector2 m_box;

        private readonly SpriteRenderer m_renderer;
        protected ISpriteInstance m_sprite;

        private readonly SpriteSequence m_sequence;

        public LocationComponent Location { get { return m_location; } }
        public Vector2 Box { get { return m_box; } }
        public ISpriteInstance Sprite { get { return m_sprite; } }

        public FireCamp()
        {
            m_location = new LocationComponent(this);
            m_rigidBody = new RigidBodyComponent(this, m_location);
            m_renderer = new SpriteRenderer(FireSprites.Instance);
            m_box = new Vector2(48, 48);

            m_sequence = new SpriteSequence(
                FireSprites.Instance.Camp1,
                FireSprites.Instance.Camp2,
                FireSprites.Instance.Camp3,
                FireSprites.Instance.Camp4,
                FireSprites.Instance.Camp5
            );

            m_sequence.SpritesPerSecond = 7;

            SetSprite(m_renderer);
        }

        public void SetSprite(SpriteRenderer renderer)
        {
            m_sprite = renderer.AddSprite(FireSprites.Instance.Camp1);
        }

        public void SetPosition(Vector2 position)
        {
            m_location.SetPosition(position);
        }

        public void Update(TimeSpan elapsed)
        {
            UpdateSprite(elapsed, m_sequence);
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }

        protected void UpdateSprite(TimeSpan elapsed, SpriteSequence sequence)
        {
            m_sequence.Update(elapsed);

            m_sprite.Position = new Vector2(m_location.Position.X - m_box.X / 2, m_location.Position.Y - m_box.Y / 2);
            m_sprite.Sprite = m_sequence.CurrentSprite;
            m_sprite.Size = m_box;
        }
    }
}
