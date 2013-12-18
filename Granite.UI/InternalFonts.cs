using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    internal static partial class InternalFonts
    {
        private static readonly Lazy<Texture2D> s_texture;

        static InternalFonts()
        {
            s_texture = new Lazy<Texture2D>(() =>
            {
                return null;
            });
        }
    }
}
