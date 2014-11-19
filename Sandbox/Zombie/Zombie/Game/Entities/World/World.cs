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
            Player.AddWeapon(new Weapon(
                "Gatling gun",
                10,
                50,
                0.1,
                3,
                1000,
                new Shoot(Vector2.Zero, Vector2.Zero, new Vector4(1, 1, 1, 1), new Vector4(1, 1, 0, 1f), 0.2f, 200)));

            Player.AddWeapon(new Weapon(
                "Sniper",
                10,
                50,
                0.8,
                3,
                1000,
                new Shoot(Vector2.Zero, Vector2.Zero, new Vector4(1, 1, 1, 1), new Vector4(1, 1, 0, 1f), 0.02f, 600)));

            Player.AddWeapon(new Weapon(
                "ShotGun",
                10,
                50,
                0.5,
                3,
                1000,
                new Shoot(Vector2.Zero, Vector2.Zero, new Vector4(1, 1, 1, 1), new Vector4(1, 1, 0, 1f), 1f, 100)));

            //Ennemies
            var random = new Random();

            for (var i = 0; i < 100; i++)
            {
                var z1 = new Zombie1();
                z1.SetPosition(new Vector2((float)random.Next(0, 500),
                    (float)random.Next(0, 500)));
                z1.SetTarget(Player);
                EnnemyManager.Instance.AddEnnemy(z1);
            }

            s_instance = this;
        }

        

        public void Update(TimeSpan elapsed)
        {
            var size = Engine.Display.GetSize();
            m_camera.SetSize(new Vector2(size.X, size.Y));

            m_player.Update(elapsed);
            m_camera.Update(elapsed);

            ShootManager.Instance.Update(elapsed);

            EnnemyManager.Instance.Update(elapsed);

        }

        public void Render(Matrix4 transform)
        {
            transform *= m_camera.CreateWorldToCameraTransform();

            m_player.Render(transform);

            EnnemyManager.Instance.Render(transform);

            ShootManager.Instance.Render(transform);
        }

    }
}
