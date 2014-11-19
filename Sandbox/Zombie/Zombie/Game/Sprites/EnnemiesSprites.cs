using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Sprites
{
    public sealed class EnnemiesSprites : SpriteSheet
    {
        private static EnnemiesSprites s_instance;
        public static EnnemiesSprites Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new EnnemiesSprites();
                }

                return s_instance;
            }
        }

        public Sprite Front1 { get; private set; }
        public Sprite Front2 { get; private set; }
        public Sprite Front3 { get; private set; }
        public Sprite Left1 { get; private set; }
        public Sprite Left2 { get; private set; }
        public Sprite Left3 { get; private set; }
        public Sprite Right1 { get; private set; }
        public Sprite Right2 { get; private set; }
        public Sprite Right3 { get; private set; }
        public Sprite Back1 { get; private set; }
        public Sprite Back2 { get; private set; }
        public Sprite Back3 { get; private set; }

        private EnnemiesSprites()
        {
            Front1 = GetSprite("front_1");
            Front2 = GetSprite("front_2");
            Front3 = GetSprite("front_3");
            Left1 = GetSprite("left_1");
            Left2 = GetSprite("left_2");
            Left3 = GetSprite("left_3");
            Right1 = GetSprite("right_1");
            Right2 = GetSprite("right_2");
            Right3 = GetSprite("right_3");
            Back1 = GetSprite("back_1");
            Back2 = GetSprite("back_2");
            Back3 = GetSprite("back_3");
            
        }
    }
}
