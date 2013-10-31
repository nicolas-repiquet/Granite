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
        void Render(Display display, Graphics graphics, TimeSpan elapsed);
    }
}
