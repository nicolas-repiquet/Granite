using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public interface IDisplay
    {
        double FramesPerSecond { get; }
        void SetTitle(string title);
        void SetCursor(Cursor cursor);
        Vector2i GetSize();
        void Invalidate();
    }
}
