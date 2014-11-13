using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Entities.Components;
using Zombie.Sprites;

namespace Zombie.Entities.Ennemies
{
    public class Ennemy : Entity, ILocated, IUpdatable, IRenderable
    {
        protected readonly LocationComponent m_location;
        protected readonly RigidBodyComponent m_rigidBody;

        
        protected ISpriteInstance m_sprite;

        protected SpriteSequence m_currentSequence;

        protected Player m_target;

        public Box2 Location { get { return m_location.Location; } }
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
