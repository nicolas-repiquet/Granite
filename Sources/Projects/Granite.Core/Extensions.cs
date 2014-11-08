using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public static class Extensions
    {
        public static Stream GetAssociatedResource(this Type type, string extension)
        {
            return type.Assembly.GetManifestResourceStream(type.FullName + "." + extension);
        }
    }
}