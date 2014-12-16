using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.Ennemies;
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
            var ennemies = EnnemyManager.Instance.Ennemies.ToArray();
            
            m_renderer.Clear();

            foreach (var b in Bullets)
            {
                b.SetSprite(m_renderer);

                Parallel.For(0, ennemies.Count(), index =>
                {
                    Collision(b, ennemies[index]);
                });
            }

            Parallel.ForEach(Bullets, b =>
            {
                b.Update(elapsed);
            });

            //On supprime les balles qui sont en fin de vie
            Bullets.RemoveAll(x => x.LifeTime <= 0);
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }

        private void Collision(Bullet bullet, Ennemy ennemy)
        {
            if (ennemy.Life.IsAlive)
            {
                var vecteur = ennemy.Location.Position - bullet.Location.Position;
                var norme = Math.Sqrt(Math.Pow(vecteur.X, 2) + Math.Pow(vecteur.Y, 2));

                if (norme < 15)
                {
                    ennemy.Life.TakeDamage(bullet.Weapon.Damage);
                }
            }
        }
    }
}
