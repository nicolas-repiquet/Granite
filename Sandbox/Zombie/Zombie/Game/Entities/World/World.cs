using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Ennemies;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Entities.Weapons;

namespace Zombie.Game.Entities
{
    public sealed class World : Entity, IUpdatable, IRenderable
    {
        private readonly Camera m_camera;
        private readonly Player m_player;

        

        public Player Player { get { return m_player; } }
        public Camera Camera { get { return m_camera; } }

        private static World s_instance;
        public static World Instance {
            get
            {
                return s_instance;
            }
        }

        public World()
        {
            m_camera = new Camera();
            m_player = new Player();

            m_camera.Bounds = new Box2(0, 0, 1000, 1000);
            m_camera.Target = m_player;

            Player.SetPosition(new Vector2(350, 350));
            Player.EquipWeapon(new Weapon(
                "Gatling gun",
                10,
                50,
                0.1,
                3,
                1000,
                100));

            s_instance = this;
        }

        

        public void Update(TimeSpan elapsed)
        {
            var size = Engine.Display.GetSize();
            m_camera.SetSize(new Vector2(size.X, size.Y));

            m_player.Update(elapsed);
            m_camera.Update(elapsed);

            BulletManager.Instance.Update(elapsed);

            //EnnemyManager.Instance.Update(elapsed);
        }

        public void Render(Matrix4 transform)
        {
            transform *= m_camera.CreateWorldToCameraTransform();

            m_player.Render(transform);

            BulletManager.Instance.Render(transform);

            //EnnemyManager.Instance.Render(transform);
        }

    }
}
