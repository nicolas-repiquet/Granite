using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI.Sprites
{
    public sealed class Theme_01 : SpriteSheet
    {
        private static Theme_01 s_instance;
        public static Theme_01 Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new Theme_01();
                }
                return s_instance;
            }
        }

        private Theme_01()
        {

        }
    }
}
