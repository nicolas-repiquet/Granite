using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Effects
{
    public enum BloodType
    {
        A, B, C, D
    }

    public class BloodManager
    {
        private static BloodManager s_instance;
        public static BloodManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new BloodManager();
                }
                return s_instance;
            }
        }

        protected readonly SpriteRenderer m_renderer;

        private List<Blood> Bloods;

        public BloodManager()
        {
            Bloods = new List<Blood>();
            m_renderer = new SpriteRenderer(BloodSprites.Instance);
        }

        public void AddBlood(Blood blood)
        {
            blood.SetSprite(m_renderer);
            Bloods.Add(blood);
        }

        public void AddBlood(BloodType type, Vector2 position, Vector2 direction, Color4ub? color = null)
        {
            //Eclaboussure
            Blood blood = null;
            
            switch(type)
            {
                case BloodType.A:
                    blood = new Blood1();
                    break;
                case BloodType.B:
                    blood = new Blood2();
                    break;
                case BloodType.C:
                    blood = new Blood3();
                    break;
                case BloodType.D:
                    blood = new Blood4();
                    break;
            }
            
            blood.SetPosition(position);
            blood.SetDirection(direction);
            blood.SetColor(color);
            AddBlood(blood);

            //Sang sur le sol
            blood = new BloodFloor1();
            blood.SetPosition(position);
            var angle = (float)Math.Atan2(direction.Y, direction.X);
            blood.SetDirection(angle + (float)((RandomGenerator.Instance.Random.NextDouble() * 2) - 1));
            blood.SetColor(color);
            AddBlood(blood);
        }

        public void Update(TimeSpan elapsed)
        {
            Parallel.ForEach(Bloods, b =>
                {
                    b.Update(elapsed);
                });

            Bloods.RemoveAll(x => x.LifeTime <= 0);

            m_renderer.Clear();

            foreach (var b in Bloods)
            {
                b.SetSprite(m_renderer);
            }
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }
    }
}
