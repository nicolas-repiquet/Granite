using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Maps
{
    public sealed class Grass : Terrain
    {
        private static Grass s_instance;
        public static Grass Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new Grass();
                }

                return s_instance;
            }
        }

        private Grass()
            : base(
                TilesSprites.Instance.GrassLeft,
                TilesSprites.Instance.GrassMid,
                TilesSprites.Instance.GrassRight,
                TilesSprites.Instance.Grass,
                TilesSprites.Instance.GrassCliffLeft,
                TilesSprites.Instance.GrassCenter,
                TilesSprites.Instance.GrassCliffRight
                )
        {

        }
    }
}
