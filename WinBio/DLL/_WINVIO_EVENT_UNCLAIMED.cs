using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types.Internal
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct _WINVIO_EVENT_UNCLAIMED
    {
        public uint UnitId;
        public WINBIO_REJECT_DETAIL RejectDetail;
    }
}
