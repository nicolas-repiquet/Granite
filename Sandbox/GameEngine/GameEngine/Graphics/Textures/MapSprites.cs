using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Graphics.Textures
{
    public sealed class MapSprites : SpriteSheet
    {
        private static MapSprites s_instance;
        public static MapSprites Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new MapSprites();
                }

                return s_instance;
            }
        }

        public Sprite Grass { get; private set; }

        private MapSprites()
        {
            Grass = GetSprite("grass");
        }
    }
}
