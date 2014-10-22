using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Maps
{
    public abstract class Liquid : Material
    {
        private readonly Sprite m_top;
        private readonly Sprite m_mid;

        public Liquid(Sprite top, Sprite mid)
        {
            m_top = top;
            m_mid = mid;
        }

        public override Sprites.Sprite GetSprite(Material topLeft, Material top, Material topRight, Material left, Material right, Material bottomLeft, Material bottom, Material bottomRight)
        {
            if (top == this)
            {
                return m_mid;
            }
            else
            {
                return m_top;
            }
        }

        public override bool CanPassThrough
        {
            get
            {
                return true;
            }
        }
    }
}
