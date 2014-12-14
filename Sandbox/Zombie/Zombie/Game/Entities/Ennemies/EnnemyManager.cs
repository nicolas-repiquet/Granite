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
        public double MaxDistance { get; private set; }

        protected readonly SpriteRenderer m_renderer;

        private int m_ennemiesCount;
        private int m_ennemiesCountInitial;
        private Random m_random;

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

        public EnnemyManager(int ennemiesCount = 10)
        {
            m_ennemies = new List<Ennemy>();
            m_ennemiesCount = ennemiesCount;
            m_ennemiesCountInitial = ennemiesCount;
            m_random = new Random();

            m_renderer = new SpriteRenderer(EnnemiesSprites.Instance);
        }

        public void AddEnnemy(Ennemy ennemy)
        {
            ennemy.SetSprite(m_renderer);
            m_ennemies.Add(ennemy);
        }

        public void Update(TimeSpan elapsed)
        {
            //On modifie le nombre de zombies en fonction du moment de la journée
            var day = World.World.Instance.DayLight.DayProgress;
            if (day > 10 && day < 20)
            {
                m_ennemiesCount = m_ennemiesCountInitial * 10;
            }
            else
            {
                m_ennemiesCount = m_ennemiesCountInitial;
            }

            var size = Engine.Display.GetSize();
            var player = World.World.Instance.Player;
            var vecteur = player.Location.Position + size / 2 - player.Location.Position;
            MaxDistance = Math.Sqrt(Math.Pow(vecteur.X, 2) + Math.Pow(vecteur.Y, 2)) + 20;

            //On test les collisions entre le dernier tir et les zombies
            if (LastShoot != null)
            {
                Parallel.ForEach(m_ennemies, x => x.LastShoot.Enqueue(LastShoot));
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

            //S'il manque des zombies on complète
            for (var i = 0; i < m_ennemiesCount - m_ennemies.Count; i++)
            {
                Ennemy z = null;

                var zType = m_random.Next(1, 7);

                switch (zType)
                {
                    case 1:
                        z = new Zombie1();
                        break;
                    case 2:
                        z = new Zombie2();
                        break;
                    case 3:
                        z = new Zombie3();
                        break;
                    case 4:
                        z = new Zombie4();
                        break;
                    case 5:
                        z = new Zombie5();
                        break;
                    case 6:
                        z = new Zombie6();
                        break;
                }

                //On le met en dehors de l'écran

                //On choisit d'abords sur quel coté
                var side = m_random.Next(1, 5);

                var x = player.Location.Position.X;
                var y = player.Location.Position.Y;
                var ecart = m_random.Next(10, 200);

                switch (side)
                {
                    case 1:
                        x = player.Location.Position.X - size.X / 2 - ecart;
                        y = player.Location.Position.Y + m_random.Next(-size.Y/2, size.Y/2);
                        break;
                    case 2:
                        x = player.Location.Position.X + size.X / 2 + ecart;
                        y = player.Location.Position.Y + m_random.Next(-size.Y / 2, size.Y / 2);
                        break;
                    case 3:
                        x = player.Location.Position.X + m_random.Next(-size.X / 2, size.X / 2);
                        y = player.Location.Position.Y - size.Y / 2 - ecart;
                        break;
                    case 4:
                        x = player.Location.Position.X + m_random.Next(-size.X / 2, size.X / 2);
                        y = player.Location.Position.Y + size.Y / 2 + ecart;
                        break;
                }

                z.SetPosition(new Vector2(x, y));

                z.SetTarget(player);

                EnnemyManager.Instance.AddEnnemy(z);
            }

            Parallel.ForEach(m_ennemies, x => x.Update(elapsed));
        }

        public void Render(Matrix4 transform)
        {
            m_renderer.Render(transform);
        }
    }
}
