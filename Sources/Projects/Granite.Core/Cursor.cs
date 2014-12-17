using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public enum Cursor : uint
    {
        None = 0,
        Arrow = WinApi.IDC_ARROW,
        ArrowWait = WinApi.IDC_APPSTARTING,
        ArrowHelp = WinApi.IDC_HELP,
        Cross = WinApi.IDC_CROSS,
        Hand = WinApi.IDC_HAND,
        IBeam = WinApi.IDC_IBEAM,
        SizeAll = WinApi.IDC_SIZEALL,
        SizeNeSw = WinApi.IDC_SIZENESW,
        SizeNS = WinApi.IDC_SIZENS,
        SizeNwSe = WinApi.IDC_SIZENWSE,
        SizeWE = WinApi.IDC_SIZEWE,
        UpArrow = WinApi.IDC_UPARROW,
        Wait = WinApi.IDC_WAIT
    }
}
