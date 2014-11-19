﻿using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Weapons;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities
{
    public class Player : Entity, ILocated, IUpdatable, IRenderable
    {
        private readonly LocationComponent m_location;
        private readonly RigidBodyComponent m_rigidBody;
        private readonly MoveComponent m_move;
        private readonly Vector2 m_box;


        private readonly SpriteRenderer m_renderer;
        private readonly ISpriteInstance m_sprite;

        private readonly SpriteSequence m_walkRightSequence;
        private readonly SpriteSequence m_walkLeftSequence;
        private readonly SpriteSequence m_walkFrontSequence;
        private readonly SpriteSequence m_walkBackSequence;

        private SpriteSequence m_currentSequence;
        private Weapon m_weapon;
        private Dictionary<string, Weapon> m_weapons;

        public LocationComponent Location { get { return m_location; } }
        public Vector2 Box { get { return m_box; } }
        public RigidBodyComponent RigidBody { get { return m_rigidBody; } }
        public MoveComponent Move { get { return m_move; } }
        public Weapon Weapon { get { return m_weapon; } }
        public Dictionary<string, Weapon> Weapons { get { return m_weapons; } }

        //public bool NeedMove { set; get; }

        public Player()
        {
            m_location = new LocationComponent(this);
            m_rigidBody = new RigidBodyComponent(this, m_location);
            m_move = new MoveComponent(this, m_location);
            m_box = new Vector2(32, 32);
            m_weapons = new Dictionary<string, Weapon>();

            m_renderer = new SpriteRenderer(PlayerSprites.Instance);
            m_sprite = m_renderer.AddSprite(PlayerSprites.Instance.Front1);

            m_walkRightSequence = new SpriteSequence(
                PlayerSprites.Instance.Right1,
                PlayerSprites.Instance.Right2,
                PlayerSprites.Instance.Right3
            );

            m_walkLeftSequence = new SpriteSequence(
               PlayerSprites.Instance.Left1,
               PlayerSprites.Instance.Left2,
               PlayerSprites.Instance.Left3
           );

           m_walkFrontSequence = new SpriteSequence(
               PlayerSprites.Instance.Front1,
               PlayerSprites.Instance.Front2,
               PlayerSprites.Instance.Front3
           );

           m_walkBackSequence = new SpriteSequence(
               PlayerSprites.Instance.Back1,
               PlayerSprites.Instance.Back2,
               PlayerSprites.Instance.Back3
           );
        }

        public void AddWeapon(Weapon weapon)
        {
            if(!Weapons.ContainsKey(weapon.Name))
            {
                Weapons.Add(weapon.Name, weapon);
            }

            if (m_weapon == null)
            {
                EquipWeapon(weapon.Name);
            }
        }

        public void EquipWeapon(string name)
        {
            if (Weapons.ContainsKey(name))
            {
                m_weapon = Weapons[name];
                Console.WriteLine("Player equip " + name);
            }
        }

        public void NextWeapon()
        {
            if (Weapons.Count > 1)
            {
                List<string> keys = new List<string>(Weapons.Keys);
                var index = keys.IndexOf(m_weapon.Name);

                var newIndex = index + 1;
                if (newIndex >= Weapons.Count)
                {
                    newIndex = 0;
                }

                EquipWeapon(keys.ElementAt(newIndex));
            }
        }

        private SpriteSequence GetSpriteSequence()
        {
            SpriteSequence seq = null;

            if (Math.Abs(m_move.LastDirection.X) > Math.Abs(m_move.LastDirection.Y))
            {
                if (m_move.LastDirection.X > 0)
                {
                    seq = m_walkRightSequence;
                }
                else if (m_move.LastDirection.X < 0)
                {
                    seq = m_walkLeftSequence;
                }
            }
            else
            {
                if (m_move.LastDirection.Y > 0)
                {
                    seq = m_walkBackSequence;
                }
                else if (m_move.LastDirection.Y < 0)
                {
                    seq = m_walkFrontSequence;
                }
            }

            if (seq == null)
            {
                seq = m_walkFrontSequence;
            }

            return seq;
        }

        public void SetPosition(Vector2 position)
        {
            m_location.SetPosition(position);
        }

        public void Update(TimeSpan elapsed)
        {
            m_rigidBody.Update(elapsed);
            m_move.Update(elapsed);

            //if (NeedMove)
            //{
            //    m_location.SetPosition(m_move.NewLocation);
            //    NeedMove = false;
            //}

            var sequence = GetSpriteSequence();

            if (sequence != m_currentSequence)
            {
                m_currentSequence = sequence;
                m_currentSequence.Reset();
            }

            m_currentSequence.Update(elapsed);

            if (m_weapon != null)
            {
                m_weapon.Update(elapsed);
            }
        }

        public void Render(Matrix4 transform)
        {
            m_sprite.Position = new Vector2(m_location.Position.X - m_sprite.Sprite.Size.X/2, m_location.Position.Y - m_sprite.Sprite.Size.Y/2);
            m_sprite.Sprite = m_currentSequence.CurrentSprite;
            m_sprite.Size = new Vector2(m_sprite.Sprite.Size.X, m_sprite.Sprite.Size.Y);
            m_renderer.Render(transform);
        }

        public void Fire(Vector2 target)
        {
            if (m_weapon != null)
            {
                //Console.WriteLine("Player fire with " + m_weapon.Name);
                var v = new Vector2(
                    target.X - m_location.Position.X,
                    target.Y - m_location.Position.Y
                    );
                m_weapon.Fire(m_location.Position, v.Normalize());
            }
            else
            {
                Console.WriteLine("Player don't fire because he doesn't have gun !");
            }
        }
    }
}