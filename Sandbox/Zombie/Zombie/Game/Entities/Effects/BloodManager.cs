using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Effects
{
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

        public void AddBlood(Vector2 position)
        {
            var blood = new Blood1();
            blood.SetPosition(position);
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
