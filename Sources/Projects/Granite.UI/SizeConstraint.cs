using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public struct SizeConstraint
    {
        public readonly float? Width;
        public readonly float? Height;

        public SizeConstraint(float? width, float height)
        {
            Width = width;
            Height = height;
        }
    }
}
