using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Maps
{
    public sealed class Lava : Liquid
    {
        private static Lava s_instance;
        public static Lava Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new Lava();
                }

                return s_instance;
            }
        }

        public Lava()
            : base(TilesSprites.Instance.LiquidLavaTopMid, TilesSprites.Instance.LiquidLava)
        {

        }
    }
}
