using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public abstract class DisplayLogicBase : IDisplayLogic
    {
        public virtual void OnMouseMove(Display display, int x, int y) { }
        public virtual void OnCloseCommand(Display display) { }
        public virtual void OnKeyDown(Keys key) { }
        public virtual void OnKeyUp(Keys key) { }
        public virtual void OnGainFocus() { }
        public virtual void OnLostFocus() { }
        public virtual void OnChar(char c) { }

        public virtual void Render(Display display, Graphics graphics, TimeSpan elapsed) { }
    }
}
