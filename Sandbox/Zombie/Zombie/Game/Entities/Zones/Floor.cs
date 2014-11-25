using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Sprites;

namespace Zombie.Game.Entities.Zones
{
    public class Floor : IUpdatable, IRenderable
    {
        private Zone m_zone;
        private readonly Texture2D m_backgroundTexture_01;
        private readonly SpriteSheet m_backgroundSheet_01;
        private readonly Sprite m_backgroundSprite_01;
        private readonly SpriteRenderer m_backgroundRenderer_01;
        private readonly ISpriteInstance m_backgroundInstance_01;

        public Floor(Zone zone)
        {
            m_zone = zone;

            m_backgroundTexture_01 = Texture2D.Load(typeof(Floor).Assembly.GetManifestResourceStream("Zombie.Game.Textures.grass.jpg"));
            m_backgroundSheet_01 = new SpriteSheet(m_backgroundTexture_01);
            m_backgroundSprite_01 = m_backgroundSheet_01.AddSprite("", new Box2i(Vector2i.Zero, m_backgroundTexture_01.Size));
            m_backgroundRenderer_01 = new SpriteRenderer(m_backgroundSheet_01);
            m_backgroundInstance_01 = m_backgroundRenderer_01.AddSprite(m_backgroundSprite_01);

        }

        public void Update(TimeSpan elapsed)
        {
            m_backgroundInstance_01.Position = new Vector2(0,0);
            m_backgroundInstance_01.Size = m_zone.Map.ZoneSize;
        }

        public void Render(Matrix4 transform)
        {
            m_backgroundRenderer_01.Render(transform);
        }
    }
}
