using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    [Flags()]
    public enum WINBIO_BIR_PURPOSE : byte
    {
        WINBIO_NO_PURPOSE_AVAILABLE = 0x00,
        WINBIO_PURPOSE_VERIFY = 0x01,
        WINBIO_PURPOSE_IDENTIFY = 0x02,
        WINBIO_PURPOSE_ENROLL = 0x04,
        WINBIO_PURPOSE_ENROLL_FOR_VERIFICATION = 0x08,
        WINBIO_PURPOSE_ENROLL_FOR_IDENTIFICATION = 0x10,
        WINBIO_PURPOSE_AUDIT = 0x80
    }
}
