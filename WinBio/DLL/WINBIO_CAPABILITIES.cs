using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    [Flags()]
    public enum WINBIO_CAPABILITIES : uint
    {
        WINBIO_CAPABILITY_SENSOR = 0x00000001,
        WINBIO_CAPABILITY_MATCHING = 0x00000002,
        WINBIO_CAPABILITY_DATABASE = 0x00000004,
        WINBIO_CAPABILITY_PROCESSING = 0x00000008,
        WINBIO_CAPABILITY_ENCRYPTION = 0x00000010,
        WINBIO_CAPABILITY_NAVIGATION = 0x00000020,
        WINBIO_CAPABILITY_INDICATOR = 0x00000040
    }
}
