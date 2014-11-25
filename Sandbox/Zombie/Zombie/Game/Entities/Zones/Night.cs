using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Tools;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Zones
{
    public class Night : IUpdatable, IRenderable
    {
        private Camera m_camera;
        private readonly Texture2D m_backgroundTexture_01;
        private readonly SpriteSheet m_backgroundSheet_01;
        private readonly Sprite m_backgroundSprite_01;
        private readonly SpriteRenderer m_backgroundRenderer_01;
        private readonly ISpriteInstance m_backgroundInstance_01;

        public Night(Camera camera)
        {
            m_camera = camera;

            m_backgroundTexture_01 = Texture2D.Load(typeof(Floor).Assembly.GetManifestResourceStream("Zombie.Game.Textures.night.png"));
            m_backgroundSheet_01 = new SpriteSheet(m_backgroundTexture_01);
            m_backgroundSprite_01 = m_backgroundSheet_01.AddSprite("", new Box2i(Vector2i.Zero, m_backgroundTexture_01.Size));
            m_backgroundRenderer_01 = new SpriteRenderer(m_backgroundSheet_01);
            m_backgroundInstance_01 = m_backgroundRenderer_01.AddSprite(m_backgroundSprite_01);

        }

        public void Update(TimeSpan elapsed)
        {
            m_backgroundInstance_01.Position = m_camera.Box.Position;
            m_backgroundInstance_01.Size = m_camera.Box.Size;
        }

        public void Render(Matrix4 transform)
        {
            m_backgroundRenderer_01.Render(transform);
        }
    }
}
