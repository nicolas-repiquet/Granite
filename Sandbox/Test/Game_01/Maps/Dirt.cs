using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Maps
{
    public sealed class Dirt : Terrain
    {
        private static Dirt s_instance;
        public static Dirt Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new Dirt();
                }

                return s_instance;
            }
        }

        private Dirt()
            : base(
                TilesSprites.Instance.DirtLeft,
                TilesSprites.Instance.DirtMid,
                TilesSprites.Instance.DirtRight,
                TilesSprites.Instance.Dirt,
                TilesSprites.Instance.DirtLeft,
                TilesSprites.Instance.DirtCenter,
                TilesSprites.Instance.DirtRight
                )
        {

        }
    }
}
