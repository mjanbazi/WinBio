using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    [Flags()]
    public enum WINBIO_BIR_DATA_FLAGS : byte
    {
        WINBIO_DATA_FLAG_INTEGRITY = 0x01,
        WINBIO_DATA_FLAG_PRIVACY = 0x02,
        WINBIO_DATA_FLAG_SIGNED = 0x04,
        WINBIO_DATA_FLAG_RAW = 0x20,
        WINBIO_DATA_FLAG_INTERMEDIATE = 0x40,
        WINBIO_DATA_FLAG_PROCESSED = 0x80,
        WINBIO_DATA_FLAG_OPTION_MASK_PRESENT = 0x08
    }
}
