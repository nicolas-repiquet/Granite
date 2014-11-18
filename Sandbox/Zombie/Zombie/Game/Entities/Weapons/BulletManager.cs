using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.Tools;

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

        protected readonly TriangleRenderer m_renderer;

        private List<Bullet> Bullets;

        public BulletManager()
        {
            Bullets = new List<Bullet>();
            m_renderer = new TriangleRenderer();
        }

        public void AddBullet(Bullet bullet)
        {
            Bullets.Add(bullet);
        }

        public void Update(TimeSpan elapsed)
        {
            Parallel.ForEach(Bullets, b =>
            {
                b.Update(elapsed);
            });

            m_renderer.Clear();

            foreach (var b in Bullets)
            {
                var triangles = b.Point.ToTriangles();
                foreach (var t in triangles)
                {
                    m_renderer.AddTriangle(t);
                }
            }
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }
    }
}
