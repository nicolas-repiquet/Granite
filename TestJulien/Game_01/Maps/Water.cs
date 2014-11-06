using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestJulien.Game_01.Sprites;

namespace TestJulien.Game_01.Maps
{
    public sealed class Water : Liquid
    {
        private static Water s_instance;
        public static Water Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new Water();
                }

                return s_instance;
            }
        }

        public Water()
            : base(TilesSprites.Instance.LiquidWaterTopMid, TilesSprites.Instance.LiquidWater)
        {

        }

    }
}
