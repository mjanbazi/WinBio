using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    public enum WINBIO_EVENT_TYPE : uint
    {
        WINBIO_EVENT_FP_UNCLAIMED = 0x00000001,
        WINBIO_EVENT_FP_UNCLAIMED_IDENTIFY = 0x00000002,
        WINBIO_EVENT_ERROR = 0xFFFFFFFF

    }
}
