using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Entities.Ennemies
{
    public class Ennemy : Entity, ILocated, IUpdatable, IRenderable
    {
        protected readonly LocationComponent m_location;
        protected readonly RigidBodyComponent m_rigidBody;

        protected readonly SpriteRenderer m_renderer;
        protected ISpriteInstance m_sprite;

        protected SpriteSequence m_currentSequence;

        protected Player m_target;

        public Box2 Location { get { return m_location.Location; } }

        public Ennemy()
        {
            m_location = new LocationComponent(this);
            m_rigidBody = new RigidBodyComponent(this, m_location);

            m_renderer = new SpriteRenderer(EnemiesSprites.Instance);
            
        }

        public void SetTarget(Player player)
        {
            m_target = player;
        }

        public virtual void Update(TimeSpan elapsed)
        {

        }

        public virtual void Render(Matrix4 transform)
        {

        }
    }
}
