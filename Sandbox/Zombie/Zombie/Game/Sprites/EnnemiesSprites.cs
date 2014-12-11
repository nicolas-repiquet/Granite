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

        public Sprite Z1Front1 { get; private set; }
        public Sprite Z1Front2 { get; private set; }
        public Sprite Z1Front3 { get; private set; }
        public Sprite Z1Left1 { get; private set; }
        public Sprite Z1Left2 { get; private set; }
        public Sprite Z1Left3 { get; private set; }
        public Sprite Z1Right1 { get; private set; }
        public Sprite Z1Right2 { get; private set; }
        public Sprite Z1Right3 { get; private set; }
        public Sprite Z1Back1 { get; private set; }
        public Sprite Z1Back2 { get; private set; }
        public Sprite Z1Back3 { get; private set; }

        public Sprite Z2Front1 { get; private set; }
        public Sprite Z2Front2 { get; private set; }
        public Sprite Z2Front3 { get; private set; }
        public Sprite Z2Left1 { get; private set; }
        public Sprite Z2Left2 { get; private set; }
        public Sprite Z2Left3 { get; private set; }
        public Sprite Z2Right1 { get; private set; }
        public Sprite Z2Right2 { get; private set; }
        public Sprite Z2Right3 { get; private set; }
        public Sprite Z2Back1 { get; private set; }
        public Sprite Z2Back2 { get; private set; }
        public Sprite Z2Back3 { get; private set; }

        public Sprite Z3Front1 { get; private set; }
        public Sprite Z3Front2 { get; private set; }
        public Sprite Z3Front3 { get; private set; }
        public Sprite Z3Left1 { get; private set; }
        public Sprite Z3Left2 { get; private set; }
        public Sprite Z3Left3 { get; private set; }
        public Sprite Z3Right1 { get; private set; }
        public Sprite Z3Right2 { get; private set; }
        public Sprite Z3Right3 { get; private set; }
        public Sprite Z3Back1 { get; private set; }
        public Sprite Z3Back2 { get; private set; }
        public Sprite Z3Back3 { get; private set; }

        public Sprite Z4Front1 { get; private set; }
        public Sprite Z4Front2 { get; private set; }
        public Sprite Z4Front3 { get; private set; }
        public Sprite Z4Left1 { get; private set; }
        public Sprite Z4Left2 { get; private set; }
        public Sprite Z4Left3 { get; private set; }
        public Sprite Z4Right1 { get; private set; }
        public Sprite Z4Right2 { get; private set; }
        public Sprite Z4Right3 { get; private set; }
        public Sprite Z4Back1 { get; private set; }
        public Sprite Z4Back2 { get; private set; }
        public Sprite Z4Back3 { get; private set; }

        public Sprite Z5Front1 { get; private set; }
        public Sprite Z5Front2 { get; private set; }
        public Sprite Z5Front3 { get; private set; }
        public Sprite Z5Left1 { get; private set; }
        public Sprite Z5Left2 { get; private set; }
        public Sprite Z5Left3 { get; private set; }
        public Sprite Z5Right1 { get; private set; }
        public Sprite Z5Right2 { get; private set; }
        public Sprite Z5Right3 { get; private set; }
        public Sprite Z5Back1 { get; private set; }
        public Sprite Z5Back2 { get; private set; }
        public Sprite Z5Back3 { get; private set; }

        public Sprite Z6Front1 { get; private set; }
        public Sprite Z6Front2 { get; private set; }
        public Sprite Z6Front3 { get; private set; }
        public Sprite Z6Left1 { get; private set; }
        public Sprite Z6Left2 { get; private set; }
        public Sprite Z6Left3 { get; private set; }
        public Sprite Z6Right1 { get; private set; }
        public Sprite Z6Right2 { get; private set; }
        public Sprite Z6Right3 { get; private set; }
        public Sprite Z6Back1 { get; private set; }
        public Sprite Z6Back2 { get; private set; }
        public Sprite Z6Back3 { get; private set; }

        private EnnemiesSprites()
        {
            Z1Front1 = GetSprite("z1_front_1");
            Z1Front2 = GetSprite("z1_front_2");
            Z1Front3 = GetSprite("z1_front_3");
            Z1Left1 = GetSprite("z1_left_1");
            Z1Left2 = GetSprite("z1_left_2");
            Z1Left3 = GetSprite("z1_left_3");
            Z1Right1 = GetSprite("z1_right_1");
            Z1Right2 = GetSprite("z1_right_2");
            Z1Right3 = GetSprite("z1_right_3");
            Z1Back1 = GetSprite("z1_back_1");
            Z1Back2 = GetSprite("z1_back_2");
            Z1Back3 = GetSprite("z1_back_3");

            Z2Front1 = GetSprite("z2_front_1");
            Z2Front2 = GetSprite("z2_front_2");
            Z2Front3 = GetSprite("z2_front_3");
            Z2Left1 = GetSprite("z2_left_1");
            Z2Left2 = GetSprite("z2_left_2");
            Z2Left3 = GetSprite("z2_left_3");
            Z2Right1 = GetSprite("z2_right_1");
            Z2Right2 = GetSprite("z2_right_2");
            Z2Right3 = GetSprite("z2_right_3");
            Z2Back1 = GetSprite("z2_back_1");
            Z2Back2 = GetSprite("z2_back_2");
            Z2Back3 = GetSprite("z2_back_3");

            Z3Front1 = GetSprite("z3_front_1");
            Z3Front2 = GetSprite("z3_front_2");
            Z3Front3 = GetSprite("z3_front_3");
            Z3Left1 = GetSprite("z3_left_1");
            Z3Left2 = GetSprite("z3_left_2");
            Z3Left3 = GetSprite("z3_left_3");
            Z3Right1 = GetSprite("z3_right_1");
            Z3Right2 = GetSprite("z3_right_2");
            Z3Right3 = GetSprite("z3_right_3");
            Z3Back1 = GetSprite("z3_back_1");
            Z3Back2 = GetSprite("z3_back_2");
            Z3Back3 = GetSprite("z3_back_3");

            Z4Front1 = GetSprite("z4_front_1");
            Z4Front2 = GetSprite("z4_front_2");
            Z4Front3 = GetSprite("z4_front_3");
            Z4Left1 = GetSprite("z4_left_1");
            Z4Left2 = GetSprite("z4_left_2");
            Z4Left3 = GetSprite("z4_left_3");
            Z4Right1 = GetSprite("z4_right_1");
            Z4Right2 = GetSprite("z4_right_2");
            Z4Right3 = GetSprite("z4_right_3");
            Z4Back1 = GetSprite("z4_back_1");
            Z4Back2 = GetSprite("z4_back_2");
            Z4Back3 = GetSprite("z4_back_3");

            Z5Front1 = GetSprite("z5_front_1");
            Z5Front2 = GetSprite("z5_front_2");
            Z5Front3 = GetSprite("z5_front_3");
            Z5Left1 = GetSprite("z5_left_1");
            Z5Left2 = GetSprite("z5_left_2");
            Z5Left3 = GetSprite("z5_left_3");
            Z5Right1 = GetSprite("z5_right_1");
            Z5Right2 = GetSprite("z5_right_2");
            Z5Right3 = GetSprite("z5_right_3");
            Z5Back1 = GetSprite("z5_back_1");
            Z5Back2 = GetSprite("z5_back_2");
            Z5Back3 = GetSprite("z5_back_3");

            Z6Front1 = GetSprite("z6_front_1");
            Z6Front2 = GetSprite("z6_front_2");
            Z6Front3 = GetSprite("z6_front_3");
            Z6Left1 = GetSprite("z6_left_1");
            Z6Left2 = GetSprite("z6_left_2");
            Z6Left3 = GetSprite("z6_left_3");
            Z6Right1 = GetSprite("z6_right_1");
            Z6Right2 = GetSprite("z6_right_2");
            Z6Right3 = GetSprite("z6_right_3");
            Z6Back1 = GetSprite("z6_back_1");
            Z6Back2 = GetSprite("z6_back_2");
            Z6Back3 = GetSprite("z6_back_3");
            
        }
    }
}
