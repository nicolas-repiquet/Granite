using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Effects
{
    public class Blood : Entity, ILocated, IUpdatable, IRenderable
    {
        protected readonly LocationComponent m_location;
        protected Vector2 m_box;

        protected ISpriteInstance m_sprite;

        protected SpriteSequence m_currentSequence;

        public LocationComponent Location { get { return m_location; } }
        public Vector2 Box { get { return m_box; } }
        public ISpriteInstance Sprite { get { return m_sprite; } }

        public Blood()
        {
            m_location = new LocationComponent(this);
        }

        public virtual void SetSprite(SpriteRenderer renderer)
        {
           
        }

        public virtual void Update(TimeSpan elapsed)
        {

        }

        public virtual void Render(Matrix4 transform)
        {
 
        }

        public void SetPosition(Vector2 position)
        {
            m_location.SetPosition(position);
            m_box = new Vector2(64, 64);
        }

        protected void UpdateSprite(TimeSpan elapsed, SpriteSequence sequence)
        {
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
