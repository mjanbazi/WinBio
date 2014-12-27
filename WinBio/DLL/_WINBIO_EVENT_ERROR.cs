using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types.Internal
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct _WINBIO_EVENT_ERROR
    {
        public int ErrorCode;
    }
}
