using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite3D
{
    public interface IBufferView
    {
        Buffer Buffer { get; }
        int Size { get; }
        uint Type { get; }
        int Offset { get; }
        int Stride { get; }
    }
}
