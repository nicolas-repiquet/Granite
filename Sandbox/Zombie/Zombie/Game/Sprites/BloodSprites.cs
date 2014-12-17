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

        public Sprite Blood10 { get; private set; }
        public Sprite Blood11 { get; private set; }
        public Sprite Blood12 { get; private set; }
        public Sprite Blood13 { get; private set; }
        public Sprite Blood14 { get; private set; }
        public Sprite Blood15 { get; private set; }

        public Sprite Blood20 { get; private set; }
        public Sprite Blood21 { get; private set; }
        public Sprite Blood22 { get; private set; }
        public Sprite Blood23 { get; private set; }
        public Sprite Blood24 { get; private set; }
        public Sprite Blood25 { get; private set; }

        public Sprite Blood30 { get; private set; }
        public Sprite Blood31 { get; private set; }
        public Sprite Blood32 { get; private set; }
        public Sprite Blood33 { get; private set; }
        public Sprite Blood34 { get; private set; }
        public Sprite Blood35 { get; private set; }


        private BloodSprites()
        {
            Blood00 = GetSprite("blood00");
            Blood01 = GetSprite("blood01");
            Blood02 = GetSprite("blood02");
            Blood03 = GetSprite("blood03");
            Blood04 = GetSprite("blood04");
            Blood05 = GetSprite("blood05");

            Blood10 = GetSprite("blood10");
            Blood11 = GetSprite("blood11");
            Blood12 = GetSprite("blood12");
            Blood13 = GetSprite("blood13");
            Blood14 = GetSprite("blood14");
            Blood15 = GetSprite("blood15");

            Blood20 = GetSprite("blood20");
            Blood21 = GetSprite("blood21");
            Blood22 = GetSprite("blood22");
            Blood23 = GetSprite("blood23");
            Blood24 = GetSprite("blood24");
            Blood25 = GetSprite("blood25");

            Blood30 = GetSprite("blood30");
            Blood31 = GetSprite("blood31");
            Blood32 = GetSprite("blood32");
            Blood33 = GetSprite("blood33");
            Blood34 = GetSprite("blood34");
            Blood35 = GetSprite("blood35");
        }
    }
}
