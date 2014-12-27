using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types
{
    // http://msdn.microsoft.com/en-us/library/dd401663(VS.85).aspx
    [StructLayout(LayoutKind.Sequential)]
    internal struct WINBIO_STORAGE_SCHEMA
    {
        public WINBIO_BIOMETRIC_TYPE BiometricFactor;
        public Guid DatabaseId;
        public Guid DataFormat;
        public WINBIO_DATABASE Attributes;
        public WINBIO_STRING FilePath;
        public WINBIO_STRING ConnectionString;
    }
}
