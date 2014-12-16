using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Weapons.Bullets
{
    public class Bullet : Entity, ICloneable
    {
        #region Properties
        protected Weapon m_weapon;
        protected LocationComponent m_location;
        protected MoveComponent m_move;

        protected Vector2 m_box;
        protected SpriteSequence m_currentSequence;
        protected ISpriteInstance m_sprite;

        private double m_lifeTime;
        private double m_lifeTimeTotal;
        #endregion

        #region Accessors
        public Vector2 Box { get { return m_box; } }
        public ISpriteInstance Sprite { get { return m_sprite; } }
        public double LifeTime { get { return m_lifeTime; } }
        #endregion

        #region Constructor
        public Bullet()
        {
            m_location = new LocationComponent(this);
            m_move = new MoveComponent(this, m_location);

            m_lifeTimeTotal = 0.5;
            m_lifeTime = m_lifeTimeTotal;
        }
        #endregion

        #region Methods
        public virtual void SetSprite(SpriteRenderer renderer)
        {

        }

        public virtual void Update(TimeSpan elapsed)
        {
            m_lifeTime -= elapsed.TotalSeconds;

            var newPos = m_location.Position + m_move.Direction * (float)elapsed.TotalSeconds * (float)m_move.Speed;
            m_location.SetPosition(newPos);
        }

        public virtual void Render(Matrix4 transform)
        {

        }

        public void SetSpeed(double speed)
        {
            m_move.Speed = speed;
        }

        public virtual void SetPosition(Vector2 position)
        {
            m_location.SetPosition(position);
            m_box = new Vector2(24, 2);
        }

        protected void UpdateSprite(TimeSpan elapsed, SpriteSequence sequence)
        {
            if (sequence != m_currentSequence)
            {
                m_currentSequence = sequence;
                m_currentSequence.Reset();
            }

            m_currentSequence.Update(elapsed);

            m_sprite.Position = new Vector2(m_location.Position.X, m_location.Position.Y - m_box.Y / 2);
            m_sprite.Sprite = m_currentSequence.CurrentSprite;
            m_sprite.Size = m_box;
            m_sprite.Angle = (float)Math.Atan2(m_move.Direction.Y, m_move.Direction.X);
            m_sprite.Color = new Color4ub(255, 255, 150, 255);
            m_sprite.RotateFromOrigin = true;
        }

        public void SetWeapon(Weapon weapon)
        {
            m_weapon = weapon;
        }

        public void SetDirection(Vector2 direction)
        {
            m_move.Direction = direction;
        }

        public object Clone()
        {
            var clone = (Bullet)this.MemberwiseClone();
            clone.m_location = (LocationComponent)m_location.Clone();
            clone.m_move = (MoveComponent)m_move.Clone();

            return (object)clone;
        }
        #endregion
    }
}