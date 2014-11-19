using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Ennemies
{
    public class EnnemyManager
    {
        private List<Ennemy> m_ennemies;
        public List<Ennemy> Ennemies { get { return m_ennemies; } }

        protected readonly SpriteRenderer m_renderer;

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
            Parallel.ForEach(m_ennemies, x => x.Update(elapsed));
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }
    }
}
