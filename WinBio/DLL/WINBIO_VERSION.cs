using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WINBIO_VERSION
    {
        public int MajorVersion;
        public int MinorVersion;
        public override string ToString()
        {
            return string.Format("{0}.{1}", MajorVersion, MinorVersion);
        }
    }
}
