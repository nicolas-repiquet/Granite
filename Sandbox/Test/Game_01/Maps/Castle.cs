using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Maps
{
    public sealed class Castle : Terrain
    {
        private static Castle s_instance;
        public static Castle Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new Castle();
                }

                return s_instance;
            }
        }

        private Castle()
            : base(
                TilesSprites.Instance.CastleLeft,
                TilesSprites.Instance.CastleMid,
                TilesSprites.Instance.CastleRight,
                TilesSprites.Instance.Castle,
                TilesSprites.Instance.CastleCliffLeft,
                TilesSprites.Instance.CastleCenter,
                TilesSprites.Instance.CastleCliffRight
                )
        {

        }
    }
}
