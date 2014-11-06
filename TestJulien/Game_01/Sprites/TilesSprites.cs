using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJulien.Game_01.Sprites
{
    public sealed class TilesSprites : SpriteSheet
    {
        private static TilesSprites s_instance;
        public static TilesSprites Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new TilesSprites();
                }

                return s_instance;
            }
        }

        public Sprite Box { get; private set; }
        public Sprite BoxAlt { get; private set; }
        public Sprite BoxCoin { get; private set; }
        public Sprite BoxCoinAlt { get; private set; }
        public Sprite BoxCoinAltDisabled { get; private set; }
        public Sprite BoxCoinDisabled { get; private set; }
        public Sprite BoxEmpty { get; private set; }
        public Sprite BoxExplosive { get; private set; }
        public Sprite BoxExplosiveAlt { get; private set; }
        public Sprite BoxExplosiveDisabled { get; private set; }
        public Sprite BoxItem { get; private set; }
        public Sprite BoxItemAlt { get; private set; }
        public Sprite BoxItemAltDisabled { get; private set; }
        public Sprite BoxItemDisabled { get; private set; }
        public Sprite BoxWarning { get; private set; }
        public Sprite BrickWall { get; private set; }
        public Sprite Bridge { get; private set; }
        public Sprite BridgeLogs { get; private set; }
        public Sprite Castle { get; private set; }
        public Sprite CastleCenter { get; private set; }
        public Sprite CastleCenterRounded { get; private set; }
        public Sprite CastleCliffLeft { get; private set; }
        public Sprite CastleCliffLeftAlt { get; private set; }
        public Sprite CastleCliffRight { get; private set; }
        public Sprite CastleCliffRightAlt { get; private set; }
        public Sprite CastleHalf { get; private set; }
        public Sprite CastleHalfLeft { get; private set; }
        public Sprite CastleHalfMid { get; private set; }
        public Sprite CastleHalfRight { get; private set; }
        public Sprite CastleHillLeft { get; private set; }
        public Sprite CastleHillLeft2 { get; private set; }
        public Sprite CastleHillRight { get; private set; }
        public Sprite CastleHillRight2 { get; private set; }
        public Sprite CastleLedgeLeft { get; private set; }
        public Sprite CastleLedgeRight { get; private set; }
        public Sprite CastleLeft { get; private set; }
        public Sprite CastleMid { get; private set; }
        public Sprite CastleRight { get; private set; }
        public Sprite Dirt { get; private set; }
        public Sprite DirtCenter { get; private set; }
        public Sprite DirtCenterRounded { get; private set; }
        public Sprite DirtCliffLeft { get; private set; }
        public Sprite DirtCliffLeftAlt { get; private set; }
        public Sprite DirtCliffRight { get; private set; }
        public Sprite DirtCliffRightAlt { get; private set; }
        public Sprite DirtHalf { get; private set; }
        public Sprite DirtHalfLeft { get; private set; }
        public Sprite DirtHalfMid { get; private set; }
        public Sprite DirtHalfRight { get; private set; }
        public Sprite DirtHillLeft { get; private set; }
        public Sprite DirtHillLeft2 { get; private set; }
        public Sprite DirtHillRight { get; private set; }
        public Sprite DirtHillRight2 { get; private set; }
        public Sprite DirtLedgeLeft { get; private set; }
        public Sprite DirtLedgeRight { get; private set; }
        public Sprite DirtLeft { get; private set; }
        public Sprite DirtMid { get; private set; }
        public Sprite DirtRight { get; private set; }
        public Sprite DoorClosedMid { get; private set; }
        public Sprite DoorClosedTop { get; private set; }
        public Sprite DoorOpenMid { get; private set; }
        public Sprite DoorOpenTop { get; private set; }
        public Sprite Fence { get; private set; }
        public Sprite FenceBroken { get; private set; }
        public Sprite Grass { get; private set; }
        public Sprite GrassCenter { get; private set; }
        public Sprite GrassCenterRounded { get; private set; }
        public Sprite GrassCliffLeft { get; private set; }
        public Sprite GrassCliffLeftAlt { get; private set; }
        public Sprite GrassCliffRight { get; private set; }
        public Sprite GrassCliffRightAlt { get; private set; }
        public Sprite GrassHalf { get; private set; }
        public Sprite GrassHalfLeft { get; private set; }
        public Sprite GrassHalfMid { get; private set; }
        public Sprite GrassHalfRight { get; private set; }
        public Sprite GrassHillLeft { get; private set; }
        public Sprite GrassHillLeft2 { get; private set; }
        public Sprite GrassHillRight { get; private set; }
        public Sprite GrassHillRight2 { get; private set; }
        public Sprite GrassLedgeLeft { get; private set; }
        public Sprite GrassLedgeRight { get; private set; }
        public Sprite GrassLeft { get; private set; }
        public Sprite GrassMid { get; private set; }
        public Sprite GrassRight { get; private set; }
        public Sprite HillLarge { get; private set; }
        public Sprite HillLargeAlt { get; private set; }
        public Sprite HillSmall { get; private set; }
        public Sprite HillSmallAlt { get; private set; }
        public Sprite LadderMid { get; private set; }
        public Sprite LadderTop { get; private set; }
        public Sprite LiquidLava { get; private set; }
        public Sprite LiquidLavaTop { get; private set; }
        public Sprite LiquidLavaTopMid { get; private set; }
        public Sprite LiquidWater { get; private set; }
        public Sprite LiquidWaterTop { get; private set; }
        public Sprite LiquidWaterTopMid { get; private set; }
        public Sprite LockBlue { get; private set; }
        public Sprite LockGreen { get; private set; }
        public Sprite LockRed { get; private set; }
        public Sprite LockYellow { get; private set; }
        public Sprite RockHillLeft { get; private set; }
        public Sprite RockHillRight { get; private set; }
        public Sprite RopeAttached { get; private set; }
        public Sprite RopeHorizontal { get; private set; }
        public Sprite RopeVertical { get; private set; }
        public Sprite Sand { get; private set; }
        public Sprite SandCenter { get; private set; }
        public Sprite SandCenterRounded { get; private set; }
        public Sprite SandCliffLeft { get; private set; }
        public Sprite SandCliffLeftAlt { get; private set; }
        public Sprite SandCliffRight { get; private set; }
        public Sprite SandCliffRightAlt { get; private set; }
        public Sprite SandHalf { get; private set; }
        public Sprite SandHalfLeft { get; private set; }
        public Sprite SandHalfMid { get; private set; }
        public Sprite SandHalfRight { get; private set; }
        public Sprite SandHillLeft { get; private set; }
        public Sprite SandHillLeft2 { get; private set; }
        public Sprite SandHillRight { get; private set; }
        public Sprite SandHillRight2 { get; private set; }
        public Sprite SandLedgeLeft { get; private set; }
        public Sprite SandLedgeRight { get; private set; }
        public Sprite SandLeft { get; private set; }
        public Sprite SandMid { get; private set; }
        public Sprite SandRight { get; private set; }
        public Sprite Sign { get; private set; }
        public Sprite SignExit { get; private set; }
        public Sprite SignLeft { get; private set; }
        public Sprite SignRight { get; private set; }
        public Sprite Snow { get; private set; }
        public Sprite SnowCenter { get; private set; }
        public Sprite SnowCenterRounded { get; private set; }
        public Sprite SnowCliffLeft { get; private set; }
        public Sprite SnowCliffLeftAlt { get; private set; }
        public Sprite SnowCliffRight { get; private set; }
        public Sprite SnowCliffRightAlt { get; private set; }
        public Sprite SnowHalf { get; private set; }
        public Sprite SnowHalfLeft { get; private set; }
        public Sprite SnowHalfMid { get; private set; }
        public Sprite SnowHalfRight { get; private set; }
        public Sprite SnowHillLeft { get; private set; }
        public Sprite SnowHillLeft2 { get; private set; }
        public Sprite SnowHillRight { get; private set; }
        public Sprite SnowHillRight2 { get; private set; }
        public Sprite SnowLedgeLeft { get; private set; }
        public Sprite SnowLedgeRight { get; private set; }
        public Sprite SnowLeft { get; private set; }
        public Sprite SnowMid { get; private set; }
        public Sprite SnowRight { get; private set; }
        public Sprite Stone { get; private set; }
        public Sprite StoneCenter { get; private set; }
        public Sprite StoneCenterRounded { get; private set; }
        public Sprite StoneCliffLeft { get; private set; }
        public Sprite StoneCliffLeftAlt { get; private set; }
        public Sprite StoneCliffRight { get; private set; }
        public Sprite StoneCliffRightAlt { get; private set; }
        public Sprite StoneHalf { get; private set; }
        public Sprite StoneHalfLeft { get; private set; }
        public Sprite StoneHalfMid { get; private set; }
        public Sprite StoneHalfRight { get; private set; }
        public Sprite StoneHillLeft2 { get; private set; }
        public Sprite StoneHillRight2 { get; private set; }
        public Sprite StoneLedgeLeft { get; private set; }
        public Sprite StoneLedgeRight { get; private set; }
        public Sprite StoneLeft { get; private set; }
        public Sprite StoneMid { get; private set; }
        public Sprite StoneRigh { get; private set; }
        public Sprite StoneWall { get; private set; }
        public Sprite TochLit { get; private set; }
        public Sprite TochLit2 { get; private set; }
        public Sprite Torch { get; private set; }
        public Sprite Window { get; private set; }

        private TilesSprites()
        {
            Box = GetSprite("box");
            BoxAlt = GetSprite("boxAlt");
            BoxCoin = GetSprite("boxCoin");
            BoxCoinAlt = GetSprite("boxCoinAlt");
            BoxCoinAltDisabled = GetSprite("boxCoinAlt_disabled");
            BoxCoinDisabled = GetSprite("boxCoin_disabled");
            BoxEmpty = GetSprite("boxEmpty");
            BoxExplosive = GetSprite("boxExplosive");
            BoxExplosiveAlt = GetSprite("boxExplosiveAlt");
            BoxExplosiveDisabled = GetSprite("boxExplosive_disabled");
            BoxItem = GetSprite("boxItem");
            BoxItemAlt = GetSprite("boxItemAlt");
            BoxItemAltDisabled = GetSprite("boxItemAlt_disabled");
            BoxItemDisabled = GetSprite("boxItem_disabled");
            BoxWarning = GetSprite("boxWarning");
            BrickWall = GetSprite("brickWall");
            Bridge = GetSprite("bridge");
            BridgeLogs = GetSprite("bridgeLogs");
            Castle = GetSprite("castle");
            CastleCenter = GetSprite("castleCenter");
            CastleCenterRounded = GetSprite("castleCenter_rounded");
            CastleCliffLeft = GetSprite("castleCliffLeft");
            CastleCliffLeftAlt = GetSprite("castleCliffLeftAlt");
            CastleCliffRight = GetSprite("castleCliffRight");
            CastleCliffRightAlt = GetSprite("castleCliffRightAlt");
            CastleHalf = GetSprite("castleHalf");
            CastleHalfLeft = GetSprite("castleHalfLeft");
            CastleHalfMid = GetSprite("castleHalfMid");
            CastleHalfRight = GetSprite("castleHalfRight");
            CastleHillLeft = GetSprite("castleHillLeft");
            CastleHillLeft2 = GetSprite("castleHillLeft2");
            CastleHillRight = GetSprite("castleHillRight");
            CastleHillRight2 = GetSprite("castleHillRight2");
            CastleLedgeLeft = GetSprite("castleLedgeLeft");
            CastleLedgeRight = GetSprite("castleLedgeRight");
            CastleLeft = GetSprite("castleLeft");
            CastleMid = GetSprite("castleMid");
            CastleRight = GetSprite("castleRight");
            Dirt = GetSprite("dirt");
            DirtCenter = GetSprite("dirtCenter");
            DirtCenterRounded = GetSprite("dirtCenter_rounded");
            DirtCliffLeft = GetSprite("dirtCliffLeft");
            DirtCliffLeftAlt = GetSprite("dirtCliffLeftAlt");
            DirtCliffRight = GetSprite("dirtCliffRight");
            DirtCliffRightAlt = GetSprite("dirtCliffRightAlt");
            DirtHalf = GetSprite("dirtHalf");
            DirtHalfLeft = GetSprite("dirtHalfLeft");
            DirtHalfMid = GetSprite("dirtHalfMid");
            DirtHalfRight = GetSprite("dirtHalfRight");
            DirtHillLeft = GetSprite("dirtHillLeft");
            DirtHillLeft2 = GetSprite("dirtHillLeft2");
            DirtHillRight = GetSprite("dirtHillRight");
            DirtHillRight2 = GetSprite("dirtHillRight2");
            DirtLedgeLeft = GetSprite("dirtLedgeLeft");
            DirtLedgeRight = GetSprite("dirtLedgeRight");
            DirtLeft = GetSprite("dirtLeft");
            DirtMid = GetSprite("dirtMid");
            DirtRight = GetSprite("dirtRight");
            DoorClosedMid = GetSprite("door_closedMid");
            DoorClosedTop = GetSprite("door_closedTop");
            DoorOpenMid = GetSprite("door_openMid");
            DoorOpenTop = GetSprite("door_openTop");
            Fence = GetSprite("fence");
            FenceBroken = GetSprite("fenceBroken");
            Grass = GetSprite("grass");
            GrassCenter = GetSprite("grassCenter");
            GrassCenterRounded = GetSprite("grassCenter_rounded");
            GrassCliffLeft = GetSprite("grassCliffLeft");
            GrassCliffLeftAlt = GetSprite("grassCliffLeftAlt");
            GrassCliffRight = GetSprite("grassCliffRight");
            GrassCliffRightAlt = GetSprite("grassCliffRightAlt");
            GrassHalf = GetSprite("grassHalf");
            GrassHalfLeft = GetSprite("grassHalfLeft");
            GrassHalfMid = GetSprite("grassHalfMid");
            GrassHalfRight = GetSprite("grassHalfRight");
            GrassHillLeft = GetSprite("grassHillLeft");
            GrassHillLeft2 = GetSprite("grassHillLeft2");
            GrassHillRight = GetSprite("grassHillRight");
            GrassHillRight2 = GetSprite("grassHillRight2");
            GrassLedgeLeft = GetSprite("grassLedgeLeft");
            GrassLedgeRight = GetSprite("grassLedgeRight");
            GrassLeft = GetSprite("grassLeft");
            GrassMid = GetSprite("grassMid");
            GrassRight = GetSprite("grassRight");
            HillLarge = GetSprite("hill_large");
            HillLargeAlt = GetSprite("hill_largeAlt");
            HillSmall = GetSprite("hill_small");
            HillSmallAlt = GetSprite("hill_smallAlt");
            LadderMid = GetSprite("ladder_mid");
            LadderTop = GetSprite("ladder_top");
            LiquidLava = GetSprite("liquidLava");
            LiquidLavaTop = GetSprite("liquidLavaTop");
            LiquidLavaTopMid = GetSprite("liquidLavaTop_mid");
            LiquidWater = GetSprite("liquidWater");
            LiquidWaterTop = GetSprite("liquidWaterTop");
            LiquidWaterTopMid = GetSprite("liquidWaterTop_mid");
            LockBlue = GetSprite("lock_blue");
            LockGreen = GetSprite("lock_green");
            LockRed = GetSprite("lock_red");
            LockYellow = GetSprite("lock_yellow");
            RockHillLeft = GetSprite("rockHillLeft");
            RockHillRight = GetSprite("rockHillRight");
            RopeAttached = GetSprite("ropeAttached");
            RopeHorizontal = GetSprite("ropeHorizontal");
            RopeVertical = GetSprite("ropeVertical");
            Sand = GetSprite("sand");
            SandCenter = GetSprite("sandCenter");
            SandCenterRounded = GetSprite("sandCenter_rounded");
            SandCliffLeft = GetSprite("sandCliffLeft");
            SandCliffLeftAlt = GetSprite("sandCliffLeftAlt");
            SandCliffRight = GetSprite("sandCliffRight");
            SandCliffRightAlt = GetSprite("sandCliffRightAlt");
            SandHalf = GetSprite("sandHalf");
            SandHalfLeft = GetSprite("sandHalfLeft");
            SandHalfMid = GetSprite("sandHalfMid");
            SandHalfRight = GetSprite("sandHalfRight");
            SandHillLeft = GetSprite("sandHillLeft");
            SandHillLeft2 = GetSprite("sandHillLeft2");
            SandHillRight = GetSprite("sandHillRight");
            SandHillRight2 = GetSprite("sandHillRight2");
            SandLedgeLeft = GetSprite("sandLedgeLeft");
            SandLedgeRight = GetSprite("sandLedgeRight");
            SandLeft = GetSprite("sandLeft");
            SandMid = GetSprite("sandMid");
            SandRight = GetSprite("sandRight");
            Sign = GetSprite("sign");
            SignExit = GetSprite("signExit");
            SignLeft = GetSprite("signLeft");
            SignRight = GetSprite("signRight");
            Snow = GetSprite("snow");
            SnowCenter = GetSprite("snowCenter");
            SnowCenterRounded = GetSprite("snowCenter_rounded");
            SnowCliffLeft = GetSprite("snowCliffLeft");
            SnowCliffLeftAlt = GetSprite("snowCliffLeftAlt");
            SnowCliffRight = GetSprite("snowCliffRight");
            SnowCliffRightAlt = GetSprite("snowCliffRightAlt");
            SnowHalf = GetSprite("snowHalf");
            SnowHalfLeft = GetSprite("snowHalfLeft");
            SnowHalfMid = GetSprite("snowHalfMid");
            SnowHalfRight = GetSprite("snowHalfRight");
            SnowHillLeft = GetSprite("snowHillLeft");
            SnowHillLeft2 = GetSprite("snowHillLeft2");
            SnowHillRight = GetSprite("snowHillRight");
            SnowHillRight2 = GetSprite("snowHillRight2");
            SnowLedgeLeft = GetSprite("snowLedgeLeft");
            SnowLedgeRight = GetSprite("snowLedgeRight");
            SnowLeft = GetSprite("snowLeft");
            SnowMid = GetSprite("snowMid");
            SnowRight = GetSprite("snowRight");
            Stone = GetSprite("stone");
            StoneCenter = GetSprite("stoneCenter");
            StoneCenterRounded = GetSprite("stoneCenter_rounded");
            StoneCliffLeft = GetSprite("stoneCliffLeft");
            StoneCliffLeftAlt = GetSprite("stoneCliffLeftAlt");
            StoneCliffRight = GetSprite("stoneCliffRight");
            StoneCliffRightAlt = GetSprite("stoneCliffRightAlt");
            StoneHalf = GetSprite("stoneHalf");
            StoneHalfLeft = GetSprite("stoneHalfLeft");
            StoneHalfMid = GetSprite("stoneHalfMid");
            StoneHalfRight = GetSprite("stoneHalfRight");
            StoneHillLeft2 = GetSprite("stoneHillLeft2");
            StoneHillRight2 = GetSprite("stoneHillRight2");
            StoneLedgeLeft = GetSprite("stoneLedgeLeft");
            StoneLedgeRight = GetSprite("stoneLedgeRight");
            StoneLeft = GetSprite("stoneLeft");
            StoneMid = GetSprite("stoneMid");
            StoneRigh = GetSprite("stoneRigh");
            StoneWall = GetSprite("stoneWall");
            TochLit = GetSprite("tochLit");
            TochLit2 = GetSprite("tochLit2");
            Torch = GetSprite("torch");
            Window = GetSprite("window");
        }
    }
}
