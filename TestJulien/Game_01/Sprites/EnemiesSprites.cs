using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJulien.Game_01.Sprites
{
    public sealed class EnemiesSprites : SpriteSheet
    {
        private static EnemiesSprites s_instance;
        public static EnemiesSprites Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new EnemiesSprites();
                }

                return s_instance;
            }
        }

        public Sprite BlockerBody { get; private set; }
        public Sprite BlockerMad { get; private set; }
        public Sprite BlockerSad { get; private set; }
        public Sprite FishDead { get; private set; }
        public Sprite FishSwim1 { get; private set; }
        public Sprite FishSwim2 { get; private set; }
        public Sprite FlyDead { get; private set; }
        public Sprite FlyFly1 { get; private set; }
        public Sprite FlyFly2 { get; private set; }
        public Sprite PokerMad { get; private set; }
        public Sprite PokerSad { get; private set; }
        public Sprite SlimeDead { get; private set; }
        public Sprite SlimeWalkRight1 { get; private set; }
        public Sprite SlimeWalkRight2 { get; private set; }
        public Sprite SnailShell { get; private set; }
        public Sprite SnailShellUpsideDown { get; private set; }
        public Sprite SnailWalk1 { get; private set; }
        public Sprite SnailWalk2 { get; private set; }

        public Sprite SlimeWalkLeft1 { get; private set; }
        public Sprite SlimeWalkLeft2 { get; private set; }

        private EnemiesSprites()
        {
            BlockerBody = GetSprite("blockerBody");
            BlockerMad = GetSprite("blockerMad");
            BlockerSad = GetSprite("blockerSad");
            FishDead = GetSprite("fishDead");
            FishSwim1 = GetSprite("fishSwim1");
            FishSwim2 = GetSprite("fishSwim2");
            FlyDead = GetSprite("flyDead");
            FlyFly1 = GetSprite("flyFly1");
            FlyFly2 = GetSprite("flyFly2");
            PokerMad = GetSprite("pokerMad");
            PokerSad = GetSprite("pokerSad");
            SlimeDead = GetSprite("slimeDead");
            SlimeWalkRight1 = GetSprite("slimeWalkRight1");
            SlimeWalkRight2 = GetSprite("slimeWalkRight2");
            SnailShell = GetSprite("snailShell");
            SnailShellUpsideDown = GetSprite("snailShell_upsidedown");
            SnailWalk1 = GetSprite("snailWalk1");
            SnailWalk2 = GetSprite("snailWalk2");

            SlimeWalkLeft1 = GetSprite("slimeWalkLeft1");
            SlimeWalkLeft2 = GetSprite("slimeWalkLeft2");
        }
    }
}
