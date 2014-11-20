using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Entities.Weapons;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Ennemies
{
    public class EnnemyManager
    {
        private List<Ennemy> m_ennemies;
        public List<Ennemy> Ennemies { get { return m_ennemies; } }

        protected readonly SpriteRenderer m_renderer;

        private Shoot m_lastShoot;
        public Shoot LastShoot { 
            get { return m_lastShoot; }
            set { m_lastShoot = value; }
        }

        private static EnnemyManager s_instance;
        public static EnnemyManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new EnnemyManager();
                }
                return s_instance;
            }
        }

        public EnnemyManager()
        {
            m_ennemies = new List<Ennemy>();

            m_renderer = new SpriteRenderer(EnnemiesSprites.Instance);
        }

        public void AddEnnemy(Ennemy ennemy)
        {
            ennemy.SetSprite(m_renderer);
            m_ennemies.Add(ennemy);
        }

        public void Update(TimeSpan elapsed)
        {
            //On test les collisions entre le dernier tir et les zombies
            if (LastShoot != null)
            {
                Parallel.ForEach(m_ennemies, x => x.LastShoot = LastShoot);
                LastShoot = null;
            }

            if (m_ennemies.Any(x => !x.Life.IsAlive))
            {
                m_ennemies.RemoveAll(x => !x.Life.IsAlive);

                m_renderer.Clear();

                foreach (var ennemy in m_ennemies)
                {
                    ennemy.SetSprite(m_renderer);
                }
            }

            Parallel.ForEach(m_ennemies, x => x.Update(elapsed));
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }
    }
}
