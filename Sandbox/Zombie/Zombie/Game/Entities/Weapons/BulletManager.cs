using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Entities.Weapons.Bullets;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Weapons
{
    public class BulletManager
    {
        private static BulletManager s_instance;
        public static BulletManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new BulletManager();
                }
                return s_instance;
            }
        }

        protected readonly SpriteRenderer m_renderer;

        private List<Bullet> Bullets;

        public BulletManager()
        {
            Bullets = new List<Bullet>();
            m_renderer = new SpriteRenderer(BulletSprites.Instance);
        }

        public void AddBullet(Bullet bullet)
        {
            bullet.SetSprite(m_renderer);
            Bullets.Add(bullet);
        }

        public void Update(TimeSpan elapsed)
        {
            Parallel.ForEach(Bullets, b =>
            {
                b.Update(elapsed);
            });

            Bullets.RemoveAll(x => x.LifeTime <= 0);

            m_renderer.Clear();

            foreach (var b in Bullets)
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
