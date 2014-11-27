using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Sprites;
using Zombie.Game.Textures;

namespace Zombie.Game.Entities.Zones
{
    public class Floor : IUpdatable, IRenderable
    {
        private Zone m_zone;

        private readonly SpriteRenderer m_backgroundRenderer;
        private readonly ISpriteInstance m_backgroundInstance;

        public Floor(Zone zone)
        {
            m_zone = zone;

            m_backgroundRenderer = new SpriteRenderer(GrassTexture.Instance.SpriteSheet);
            m_backgroundInstance = m_backgroundRenderer.AddSprite(GrassTexture.Instance.Sprite);

        }

        public void Update(TimeSpan elapsed)
        {
            m_backgroundInstance.Position = new Vector2(0,0);
            m_backgroundInstance.Size = m_zone.Map.ZoneSize;
        }

        public void Render(Matrix4 transform)
        {
            m_backgroundRenderer.Render(transform);
        }
    }
}
