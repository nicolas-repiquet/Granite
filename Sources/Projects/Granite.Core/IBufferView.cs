using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public interface IBufferView<T>
    {
        Buffer Buffer { get; }
        int Size { get; }
        uint Type { get; }
        int Offset { get; }
        int Stride { get; }
    }
}
