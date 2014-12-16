using Granite.Collision;
using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Effects;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Entities.Weapons;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Ennemies
{
    public class Ennemy : Entity, ILocated, IUpdatable, IRenderable
    {
        protected readonly LocationComponent m_location;
        protected readonly MoveComponent m_move;
        protected readonly RigidBodyComponent m_rigidBody;
        protected readonly LifeComponent m_life;
        protected Vector2 m_box;
        
        protected ISpriteInstance m_sprite;

        protected SpriteSequence m_currentSequence;

        protected Player m_target;

        public LocationComponent Location { get { return m_location; } }
        public LifeComponent Life { get { return m_life; } }
        public MoveComponent Move { get { return m_move; } }
        public Vector2 Box { get { return m_box; } }
        public ISpriteInstance Sprite { get { return m_sprite; } }

        public Ennemy()
        {
            m_location = new LocationComponent(this);
            m_move = new MoveComponent(this, m_location);
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

        public virtual void SetPosition(Vector2 position)
        {
            m_location.SetPosition(position);
            m_box = new Vector2(32, 36);
        }

        public virtual void Update(TimeSpan elapsed)
        {
            m_move.Update(elapsed);

            var player = World.World.Instance.Player;
            var vecteur = player.Location.Position - m_location.Position;
            var distance = Math.Sqrt(Math.Pow(vecteur.X, 2) + Math.Pow(vecteur.Y, 2));

            if (distance > EnnemyManager.Instance.MaxDistance)
            {
                this.Life.InstantDeath();
            }
            else if (distance < 10 && player.Life.IsAlive)
            {
                var damage = RandomGenerator.Instance.Random.Next(5, 15);
                player.Life.TakeDamage(damage);
                Console.WriteLine("Player take " + damage + " damages (" + player.Life.Life + ")");
            }

            if (m_life.HasTakenDamage.HasValue)
            {
                BloodManager.Instance.AddBlood(m_life.HasTakenDamage.Value, m_location.Position, vecteur * -1);
                m_life.DamageProcessed();
            }
        }

        public virtual void Render(Matrix4 transform)
        {
 
        }
    }
}
