using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Maps
{
    public abstract class Material
    {
        public abstract Sprite GetSprite(
            Material topLeft, Material top, Material topRight,
            Material left, Material right,
            Material bottomLeft, Material bottom, Material bottomRight);

        public virtual bool CanPassThrough { get { return false; } }
    }
}