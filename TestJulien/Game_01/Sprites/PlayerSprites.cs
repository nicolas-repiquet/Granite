using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJulien.Game_01.Sprites
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

        public Sprite DuckRight { get; private set; }
        public Sprite FrontRight { get; private set; }
        public Sprite HurtRight { get; private set; }
        public Sprite JumpRight { get; private set; }
        public Sprite StandRight { get; private set; }
        public Sprite WalkRight01 { get; private set; }
        public Sprite WalkRight02 { get; private set; }
        public Sprite WalkRight03 { get; private set; }
        public Sprite WalkRight04 { get; private set; }
        public Sprite WalkRight05 { get; private set; }
        public Sprite WalkRight06 { get; private set; }
        public Sprite WalkRight07 { get; private set; }
        public Sprite WalkRight08 { get; private set; }
        public Sprite WalkRight09 { get; private set; }
        public Sprite WalkRight10 { get; private set; }
        public Sprite WalkRight11 { get; private set; }

        public Sprite DuckLeft { get; private set; }
        public Sprite FrontLeft { get; private set; }
        public Sprite HurtLeft { get; private set; }
        public Sprite JumpLeft { get; private set; }
        public Sprite StandLeft { get; private set; }
        public Sprite WalkLeft01 { get; private set; }
        public Sprite WalkLeft02 { get; private set; }
        public Sprite WalkLeft03 { get; private set; }
        public Sprite WalkLeft04 { get; private set; }
        public Sprite WalkLeft05 { get; private set; }
        public Sprite WalkLeft06 { get; private set; }
        public Sprite WalkLeft07 { get; private set; }
        public Sprite WalkLeft08 { get; private set; }
        public Sprite WalkLeft09 { get; private set; }
        public Sprite WalkLeft10 { get; private set; }
        public Sprite WalkLeft11 { get; private set; }

        private PlayerSprites()
        {
            DuckRight = GetSprite("duck_right");
            FrontRight = GetSprite("front_right");
            HurtRight = GetSprite("hurt_right");
            JumpRight = GetSprite("jump_right");
            StandRight = GetSprite("stand_right");
            WalkRight01 = GetSprite("walk_right_01");
            WalkRight02 = GetSprite("walk_right_02");
            WalkRight03 = GetSprite("walk_right_03");
            WalkRight04 = GetSprite("walk_right_04");
            WalkRight05 = GetSprite("walk_right_05");
            WalkRight06 = GetSprite("walk_right_06");
            WalkRight07 = GetSprite("walk_right_07");
            WalkRight08 = GetSprite("walk_right_08");
            WalkRight09 = GetSprite("walk_right_09");
            WalkRight10 = GetSprite("walk_right_10");
            WalkRight11 = GetSprite("walk_right_11");

            DuckLeft = GetSprite("duck_left");
            FrontLeft = GetSprite("front_left");
            HurtLeft = GetSprite("hurt_left");
            JumpLeft = GetSprite("jump_left");
            StandLeft = GetSprite("stand_left");
            WalkLeft01 = GetSprite("walk_left_01");
            WalkLeft02 = GetSprite("walk_left_02");
            WalkLeft03 = GetSprite("walk_left_03");
            WalkLeft04 = GetSprite("walk_left_04");
            WalkLeft05 = GetSprite("walk_left_05");
            WalkLeft06 = GetSprite("walk_left_06");
            WalkLeft07 = GetSprite("walk_left_07");
            WalkLeft08 = GetSprite("walk_left_08");
            WalkLeft09 = GetSprite("walk_left_09");
            WalkLeft10 = GetSprite("walk_left_10");
            WalkLeft11 = GetSprite("walk_left_11");
        }
    }
}
