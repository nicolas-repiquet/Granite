using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public abstract class UIElement
    {
        public Box2 Bounds { get; set; }
        public UIElement Parent { get; internal set; }
        public abstract IEnumerable<UIElement> Children { get; }
        public abstract void Render(Graphics graphics, TimeSpan elapsed);
    }
}
