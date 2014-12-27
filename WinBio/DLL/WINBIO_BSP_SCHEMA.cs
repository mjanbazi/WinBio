using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WINBIO_BSP_SCHEMA
    {
        public WINBIO_BIOMETRIC_TYPE BiometricFactor;
        public Guid BspId;
        public WINBIO_STRING Description;
        public WINBIO_STRING Vendor;
        public WINBIO_VERSION Version;
    }
}
