using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.UI
{
    public class FloatingText
    {
        public string Text { get; set; }
        public FloatingTextType Color { get; set; }
        public double TTL { get; set; }
        public Vector2 Position { get; set; }
        public float Scale { get; set; }
        public Vector2 Direction { get; set; }
        public float Speed { get; set; }
        public UILabel Label { get; set; }

        public FloatingText()
        {
            TTL = 1;
            Scale = 1;
            Speed = 10;
            Direction = new Vector2(0, 1);
        }
    }
}
