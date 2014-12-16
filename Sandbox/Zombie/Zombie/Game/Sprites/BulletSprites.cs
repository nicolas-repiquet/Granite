using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Sprites
{
    public sealed class BulletSprites : SpriteSheet
    {
        private static BulletSprites s_instance;
        public static BulletSprites Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new BulletSprites();
                }

                return s_instance;
            }
        }

        public Sprite Bullet0 { get; private set; }

        private BulletSprites()
        {
            Bullet0 = GetSprite("bullet0");
            
        }
    }
}
