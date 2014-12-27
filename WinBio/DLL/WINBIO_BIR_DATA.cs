using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WINBIO_BIR_DATA
    {
        public uint Size;
        public uint Offset;
    }
}
