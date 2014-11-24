using Granite.Collision;
using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Weapons;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Ennemies
{
    public class Ennemy : Entity, ILocated, IUpdatable, IRenderable
    {
        protected readonly LocationComponent m_location;
        protected readonly RigidBodyComponent m_rigidBody;
        protected readonly LifeComponent m_life;
        protected Vector2 m_box;
        
        protected ISpriteInstance m_sprite;

        protected SpriteSequence m_currentSequence;

        protected Player m_target;

        private Shoot m_lastShoot;
        public Shoot LastShoot
        {
            get { return m_lastShoot; }
            set { m_lastShoot = value; }
        }

        public LocationComponent Location { get { return m_location; } }
        public LifeComponent Life { get { return m_life; } }
        public Vector2 Box { get { return m_box; } }
        public ISpriteInstance Sprite { get { return m_sprite; } }

        public Ennemy()
        {
            m_location = new LocationComponent(this);
            m_rigidBody = new RigidBodyComponent(this, m_location);
            m_life = new LifeComponent(this, 50);  
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
            if(LastShoot != null)
            {
                CollisionShoot();

                LastShoot = null;
            }
        }

        public virtual void Render(Matrix4 transform)
        {
 
        }

        private void CollisionShoot()
        {
            var collide = LastShoot.Cone.Collision(m_location.Position, 10);

            if (collide)
            {
                m_life.TakeDamage(LastShoot.Weapon.Damage);
                Console.WriteLine("Ennemy take " + LastShoot.Weapon.Damage + " damages (" + m_life.Life + ")");
            }

            //foreach(var triangle in LastShoot.Cone.Triangles)
            //{
            //    var listPoint = new List<Vector2>()
            //    {
            //        new Vector2(triangle.P1.X, triangle.P1.Y), 
            //        new Vector2(triangle.P2.X, triangle.P2.Y), 
            //        new Vector2(triangle.P3.X, triangle.P3.Y)
            //    };
            //    var center = m_location.Position;

            //    var collide = Collision.Detection(listPoint, new List<Vector2>() { center });

            //    if (collide)
            //    {
            //        m_life.TakeDamage(LastShoot.Weapon.Damage);
            //        Console.WriteLine("Ennemy take " + LastShoot.Weapon.Damage + " damages (" + m_life.Life + ")");
            //        break;
            //    }
            //}
        }
    }
}
