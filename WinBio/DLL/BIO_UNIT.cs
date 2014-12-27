using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    internal enum BIO_UNIT : ushort
    {
        BIO_UNIT_MAINTENANCE = 0x0002,
        BIO_UNIT_RAW = 0x0001,
        BIO_UNIT_EXTENDED_ACCESS = 0x0008,
        BIO_UNIT_ENROLL = 0x0010,
        BIO_UNIT_OPEN_SESSION = 0x0004
    }
}
