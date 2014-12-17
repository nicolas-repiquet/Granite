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

        protected readonly TriangleFanRenderer m_renderer;

        private List<Shoot> Shoots;

        public ShootManager()
        {
            Shoots = new List<Shoot>();
            m_renderer = new TriangleFanRenderer();
        }

        public void AddShoot(Shoot shoot)
        {
            Shoots.Add(shoot);
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
                var points = b.Cone.GetPath();
                foreach (var point in points)
                {
                    m_renderer.AddVertex(point.Point, point.Color);
                }
            }
        }

        public void Render(Matrix4 transform)
        {
            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.LINE);

            m_renderer.Render(transform);

            //GL.PolygonMode(GL.FRONT_AND_BACK, GL.FILL);
        }
    }
}
