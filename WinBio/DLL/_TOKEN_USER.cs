using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types.Internal
{
    internal struct _TOKEN_USER
    {
        public _SID_AND_ATTRIBUTES User;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct _SID_AND_ATTRIBUTES
    {

        public IntPtr Sid;
        public int Attributes;
    }
}
