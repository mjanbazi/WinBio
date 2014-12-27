using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct CAPTURE_CALLBACK_CONTEXT
    {
        public WINBIO_BIR_PURPOSE Purpose;
        public WINBIO_BIR_DATA_FLAGS Flags;
    }
}
