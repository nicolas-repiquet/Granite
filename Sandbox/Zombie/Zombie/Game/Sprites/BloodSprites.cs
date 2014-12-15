using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Sprites
{
    public sealed class BloodSprites : SpriteSheet
    {
        private static BloodSprites s_instance;
        public static BloodSprites Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new BloodSprites();
                }

                return s_instance;
            }
        }

        public Sprite Blood00 { get; private set; }
        public Sprite Blood01 { get; private set; }
        public Sprite Blood02 { get; private set; }
        public Sprite Blood03 { get; private set; }
        public Sprite Blood04 { get; private set; }
        public Sprite Blood05 { get; private set; }

        private BloodSprites()
        {
            Blood00 = GetSprite("blood00");
            Blood01 = GetSprite("blood01");
            Blood02 = GetSprite("blood02");
            Blood03 = GetSprite("blood03");
            Blood04 = GetSprite("blood04");
            Blood05 = GetSprite("blood05");
            
        }
    }
}
