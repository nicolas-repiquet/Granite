using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Zones;
using Zombie.Game.Sprites;

namespace Zombie.Game.Textures
{
    public class GrassTexture
    {
        private static GrassTexture s_instance;
        public static GrassTexture Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new GrassTexture();
                }
                return s_instance;
            }
        }

        private readonly Texture2D m_backgroundTexture;
        private readonly SpriteSheet m_backgroundSheet;
        private readonly Sprite m_backgroundSprite;

        public SpriteSheet SpriteSheet { get { return m_backgroundSheet; } }
        public Sprite Sprite { get { return m_backgroundSprite; } }

        public GrassTexture()
        {
            m_backgroundTexture = Texture2D.Load(typeof(Floor).Assembly.GetManifestResourceStream("Zombie.Game.Textures.grass.jpg"));
            m_backgroundSheet = new SpriteSheet(m_backgroundTexture);
            m_backgroundSprite = m_backgroundSheet.AddSprite("", new Box2i(Vector2i.Zero, m_backgroundTexture.Size));
        }
    }
}
