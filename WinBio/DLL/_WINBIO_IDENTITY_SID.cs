using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types.Internal
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct _WINBIO_IDENTITY_SID
    {
        const int SECURITY_MAX_SID_SIZE = 68;
        public uint Size;
        public fixed byte Data[SECURITY_MAX_SID_SIZE];
    }
}
