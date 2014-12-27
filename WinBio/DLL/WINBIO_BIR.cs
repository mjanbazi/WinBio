using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WINBIO_BIR
    {
        public WINBIO_BIR_DATA HeaderBlock;
        public WINBIO_BIR_DATA StandardDataBlock;
        public WINBIO_BIR_DATA VendorDataBlock;
        public WINBIO_BIR_DATA SigntureBlock;
    }
}
