using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Effects;
using Zombie.Game.Entities.Ennemies;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Entities.Weapons;
using Zombie.Game.Entities.Weapons.Bullets;
using Zombie.Game.Entities.Zones;

namespace Zombie.Game.Entities.World
{
    public sealed class World : Entity, IUpdatable, IRenderable
    {
        private readonly Camera m_camera;
        private readonly Player m_player;
        private readonly Map m_map;
        private readonly DayLight m_dayLight;

        public Player Player { get { return m_player; } }
        public Camera Camera { get { return m_camera; } }
        public Map Map { get { return m_map; } }
        public DayLight DayLight { get { return m_dayLight; } }

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
            m_map = new Map(new Vector2i(512, 512));
            m_dayLight = new DayLight(m_map, 30, new TimeSpan(9, 0, 0));

            

            s_instance = this;
        }

        public void Initialize()
        {
            m_camera.Bounds = new Box2(0, 0, 1000, 1000);
            m_camera.Target = m_player;

            var size = Engine.Display.GetSize();
            m_camera.SetSize(new Vector2(size.X, size.Y));

            m_map.Initialize();

            Player.SetPosition(new Vector2(0, 0));
            Player.AddWeapon(new Weapon(
                "Gatling gun",
                15,
                100,
                0.1,
                3,
                1000,
                1000,
                new BulletGatling()));
            Player.AddWeapon(new Weapon(
                "Sniper",
                100,
                50,
                0.8,
                3,
                1000,
                3000,
                new BulletSniper()));
            Player.AddWeapon(new Weapon(
                "ShotGun",
                30,
                50,
                0.5,
                3,
                1000,
                700,
                new BulletGatling()));

            //Player.AddWeapon(new Weapon(
            //    "ShotGun",
            //    50,
            //    50,
            //    0.5,
            //    3,
            //    1000,
            //    new Shoot(Vector2.Zero, Vector2.Zero, new Color4ub(255, 255, 255, 255), new Color4ub(255, 255, 0, 255), 1f, 100)));

            
        }

        

        public void Update(TimeSpan elapsed)
        {
            var size = Engine.Display.GetSize();
            m_camera.SetSize(new Vector2(size.X, size.Y));

            m_player.Update(elapsed);

            m_camera.Update(elapsed);

            //ShootManager.Instance.Update(elapsed);
            BulletManager.Instance.Update(elapsed);

            BloodManager.Instance.Update(elapsed);

            EnnemyManager.Instance.Update(elapsed);

            m_map.Update(elapsed);
            m_dayLight.Update(elapsed);
        }

        public void Render(Matrix4 transform)
        {
            transform *= m_camera.CreateWorldToCameraTransform();

            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);
            GL.BlendEquation(GL.FUNC_ADD);

            m_map.Render(transform);

            GL.Enable(GL.DEPTH_TEST);

            m_player.Render(transform);

            BloodManager.Instance.Render(transform);
            
            EnnemyManager.Instance.Render(transform);

            GL.Disable(GL.DEPTH_TEST);

            m_dayLight.Render(transform);

            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            //ShootManager.Instance.Render(transform);
            BulletManager.Instance.Render(transform);

            
        }

    }
}
