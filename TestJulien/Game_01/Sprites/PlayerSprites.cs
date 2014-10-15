using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Sprites
{
    public sealed class PlayerSprites : SpriteSheet
    {
        private static PlayerSprites s_instance;
        public static PlayerSprites Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new PlayerSprites();
                }

                return s_instance;
            }
        }

        public Sprite Duck { get; private set; }
        public Sprite Front { get; private set; }
        public Sprite Hurt { get; private set; }
        public Sprite Jump { get; private set; }
        public Sprite Stand { get; private set; }
        public Sprite Walk01 { get; private set; }
        public Sprite Walk02 { get; private set; }
        public Sprite Walk03 { get; private set; }
        public Sprite Walk04 { get; private set; }
        public Sprite Walk05 { get; private set; }
        public Sprite Walk06 { get; private set; }
        public Sprite Walk07 { get; private set; }
        public Sprite Walk08 { get; private set; }
        public Sprite Walk09 { get; private set; }
        public Sprite Walk10 { get; private set; }
        public Sprite Walk11 { get; private set; }

        private PlayerSprites()
        {
            Duck = GetSprite("duck");
            Front = GetSprite("front");
            Hurt = GetSprite("hurt");
            Jump = GetSprite("jump");
            Stand = GetSprite("stand");
            Walk01 = GetSprite("walk01");
            Walk02 = GetSprite("walk02");
            Walk03 = GetSprite("walk03");
            Walk04 = GetSprite("walk04");
            Walk05 = GetSprite("walk05");
            Walk06 = GetSprite("walk06");
            Walk07 = GetSprite("walk07");
            Walk08 = GetSprite("walk08");
            Walk09 = GetSprite("walk09");
            Walk10 = GetSprite("walk10");
            Walk11 = GetSprite("walk11");
        }
    }
}
