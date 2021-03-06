﻿using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Game_01.Entities.Ennemies;
using Test.Game_01.Levels;

namespace Test.Game_01.Entities
{
    public sealed class World : Entity, IUpdatable, IRenderable
    {
        private readonly Background m_background;
        private readonly Level m_level;
        private readonly Camera m_camera;
        private readonly Player m_player;

        public Player Player { get { return m_player; } }
        public Level Level { get { return m_level; } }
        public Camera Camera { get { return m_camera; } }

        private static World s_instance;
        public static World Instance {
            get
            {
                return s_instance;
            }
        }

        public World(Level level)
        {
            m_level = level;
            m_camera = new Camera();
            m_player = new Player();
            m_background = new Background(m_camera);

            m_camera.Bounds = new Box2(0, 0, m_level.Map.Size.X, Math.Max(1000, m_level.Map.Size.Y));
            m_camera.Target = m_player;

            Player.SetPosition(new Vector2(0, 350));

            var random = new Random();

            for (var i = 0; i < 50; i++)
            {
                var slime = new Slime();
                slime.SetPosition(new Vector2((float)random.Next(0, (int)m_level.Map.Size.X), 
                    (float)random.Next(0, (int)m_level.Map.Size.Y)));
                slime.SetTarget(Player);
                EnnemyManager.Instance.AddEnnemy(slime);
            }

           

            s_instance = this;
        }

        public void Update(TimeSpan elapsed)
        {
            if (m_player.Location.Position.Y < -10)
            {
                Player.SetPosition(new Vector2(0, 500));
            }

            var size = Engine.Display.GetSize();
            m_camera.SetSize(new Vector2(size.X, size.Y));

            m_player.Update(elapsed);
            m_camera.Update(elapsed);
            m_background.Update(elapsed);

            EnnemyManager.Instance.Update(elapsed);
        }

        public void Render(Matrix4 transform)
        {
            transform *= m_camera.CreateWorldToCameraTransform();

            m_background.Render(transform);
            m_level.Map.Render(transform);
            m_player.Render(transform);

            EnnemyManager.Instance.Render(transform);
        }

    }
}
