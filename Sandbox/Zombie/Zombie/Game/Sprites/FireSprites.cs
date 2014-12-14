using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Sprites
{
    public sealed class FireSprites : SpriteSheet
    {
        private static FireSprites s_instance;
        public static FireSprites Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new FireSprites();
                }

                return s_instance;
            }
        }

        public Sprite Camp1 { get; private set; }
        public Sprite Camp2 { get; private set; }
        public Sprite Camp3 { get; private set; }
        public Sprite Camp4 { get; private set; }
        public Sprite Camp5 { get; private set; }

        private FireSprites()
        {
            Camp1 = GetSprite("camp_1");
            Camp2 = GetSprite("camp_2");
            Camp3 = GetSprite("camp_3");
            Camp4 = GetSprite("camp_4");
            Camp5 = GetSprite("camp_5");
            
        }
    }
}
