using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public World(Level level)
        {
            m_level = level;
            m_camera = new Camera();
            m_player = new Player();
            m_background = new Background(m_camera);

            m_camera.Bounds = new Box2(0, 0, m_level.Map.Size.X, Math.Max(1000, m_level.Map.Size.Y));
            m_camera.Target = m_player;

            Player.SetPosition(new Vector2(0, 500));
        }

        public void Update(TimeSpan elapsed)
        {
            var size = Engine.Display.GetSize();
            m_camera.SetSize(new Vector2(size.X, size.Y));

            m_player.Update(elapsed);
            m_camera.Update(elapsed);
            m_background.Update(elapsed);
        }

        public void Render(Matrix4 transform)
        {
            transform *= m_camera.CreateWorldToCameraTransform();

            m_background.Render(transform);
            m_level.Map.Render(transform);
            m_player.Render(transform);
        }

    }
}
