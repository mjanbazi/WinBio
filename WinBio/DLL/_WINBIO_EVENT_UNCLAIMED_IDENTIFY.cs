using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types.Internal
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct _WINBIO_EVENT_UNCLAIMED_IDENTIFY
    {
        public uint UnitId;
        public WINBIO_IDENTITY Identity;
        public WINBIO_BIOMETRIC_SUBTYPE SubFactor;
        public WINBIO_REJECT_DETAIL RejectDetail;
    }
}
