using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite3D
{
    public abstract class DisplayLogicBase : IDisplayLogic
    {
        public void OnMouseMove(Display display, int x, int y)
        {
            
        }

        public void OnCloseCommand(Display display)
        {
            
        }


        public void Render(Display display, Graphics graphics, TimeSpan elapsed)
        {
            
        }
    }
}
