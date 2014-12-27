using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct WINBIO_STRING
    {
        const int WINBIO_MAX_STRING_LEN = 256;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = WINBIO_MAX_STRING_LEN)]
        public string Value;
    }
}
