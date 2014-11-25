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
using Zombie.Game.Entities.Zones;

namespace Zombie.Game.Entities
{
    public sealed class World : Entity, IUpdatable, IRenderable
    {
        private readonly Camera m_camera;
        private readonly Player m_player;
        private readonly Map m_map;

        public Player Player { get { return m_player; } }
        public Camera Camera { get { return m_camera; } }
        public Map Map { get { return m_map; } }

        public Night Night { get; set; }

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
            m_map = new Map(new Vector2i(500, 500));

            m_camera.Bounds = new Box2(0, 0, 1000, 1000);
            m_camera.Target = m_player;

            Player.SetPosition(new Vector2(0, 0));
            Player.AddWeapon(new Weapon(
                "Gatling gun",
                25,
                100,
                0.1,
                3,
                1000,
                new Shoot(Vector2.Zero, Vector2.Zero, new Vector4(1, 1, 1, 1), new Vector4(1, 1, 0, 1f), 0.05f, 200)));

            Player.AddWeapon(new Weapon(
                "Sniper",
                100,
                50,
                0.8,
                3,
                1000,
                new Shoot(Vector2.Zero, Vector2.Zero, new Vector4(1, 1, 1, 1), new Vector4(1, 1, 0, 1f), 0.02f, 600)));

            Player.AddWeapon(new Weapon(
                "ShotGun",
                50,
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

            Night = new Night(m_camera);

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

            m_map.Update(elapsed);

            Night.Update(elapsed);
        }

        public void Render(Matrix4 transform)
        {
            transform *= m_camera.CreateWorldToCameraTransform();

            m_map.Render(transform);

            m_player.Render(transform);

            EnnemyManager.Instance.Render(transform);

            ShootManager.Instance.Render(transform);

            Night.Render(transform);
        }

    }
}
