using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.Ennemies;
using Zombie.Game.Entities.Tools;

namespace Zombie.Game.Entities.Weapons
{
    public class ShootManager
    {
        private static ShootManager s_instance;
        public static ShootManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new ShootManager();
                }
                return s_instance;
            }
        }

        protected readonly TriangleRenderer m_renderer;

        private List<Shoot> Shoots;

        public ShootManager()
        {
            Shoots = new List<Shoot>();
            m_renderer = new TriangleRenderer();
        }

        public void AddShoot(Shoot shoot)
        {
            Shoots.Add(shoot);
            EnnemyManager.Instance.LastShoot = shoot;
        }

        public void Update(TimeSpan elapsed)
        {
            Parallel.ForEach(Shoots, b =>
            {
                b.Update(elapsed);
            });

            //On vire les shoots terminés
            Shoots.RemoveAll(x => x.LifeTime <= 0);

            m_renderer.Clear();

            foreach (var b in Shoots)
            {
                var triangles = b.Cone.ToTriangles();
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
