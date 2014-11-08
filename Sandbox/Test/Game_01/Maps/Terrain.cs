using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Sprites;

namespace Test.Game_01.Maps
{
    public abstract class Terrain : Material
    {
        private readonly Sprite m_topLeft;
        private readonly Sprite m_top;
        private readonly Sprite m_topRight;
        private readonly Sprite m_topSingle;
        private readonly Sprite m_left;
        private readonly Sprite m_center;
        private readonly Sprite m_right;

        public Terrain(
            Sprite topLeft, Sprite top, Sprite topRight,
            Sprite topSingle,
            Sprite left, Sprite center, Sprite right)
        {
            m_topLeft = topLeft;
            m_top = top;
            m_topRight = topRight;
            m_topSingle = topSingle;
            m_left = left;
            m_center = center;
            m_right = right;
        }

        public override Sprites.Sprite GetSprite(
            Material topLeft, Material top, Material topRight,
            Material left, Material right,
            Material bottomLeft, Material bottom, Material bottomRight)
        {
            if (top == this)
            {
                return m_center;
            }
            else if (bottom == this)
            {
                if (left == this)
                {
                    if (right == this)
                    {
                        return m_top;
                    }
                    else
                    {
                        return m_topRight;
                    }
                }
                else
                {
                    if (right == this)
                    {
                        return m_topLeft;
                    }
                    else
                    {
                        return m_topSingle;
                    }
                }
            }
            else
            {
                if (left == this)
                {
                    if (right == this)
                    {
                        return m_top;
                    }
                    else
                    {
                        return m_right;
                    }
                }
                else
                {
                    if (right == this)
                    {
                        return m_left;
                    }
                    else
                    {
                        return m_topSingle;
                    }
                }
            }
        }
    }
}
