using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Ennemies
{
    public class Ennemy : Entity, ILocated, IUpdatable, IRenderable
    {
        private readonly LocationComponent m_location;
        private readonly RigidBodyComponent m_rigidBody;
        private readonly Vector2 m_box;
        
        protected ISpriteInstance m_sprite;

        protected SpriteSequence m_currentSequence;

        protected Player m_target;

        public LocationComponent Location { get { return m_location; } }
        public Vector2 Box { get { return m_box; } }
        public ISpriteInstance Sprite { get { return m_sprite; } }

        public Ennemy()
        {
            m_location = new LocationComponent(this);
            m_rigidBody = new RigidBodyComponent(this, m_location);

            
            
        }

        public void SetTarget(Player player)
        {
            m_target = player;
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
    }
}
