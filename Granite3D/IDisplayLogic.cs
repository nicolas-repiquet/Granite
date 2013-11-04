using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite3D
{
    public interface IDisplayLogic
    {
        void OnMouseMove(Display display, int x, int y);
        void OnCloseCommand(Display display);
        void OnKeyDown(Keys key);
        void OnKeyUp(Keys key);
        void OnGainFocus();
        void OnLostFocus();

        void Render(Display display, Graphics graphics, TimeSpan elapsed);
    }
}
