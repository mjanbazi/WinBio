using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    public enum WINBIO_BIOMETRIC_SENSOR_SUBTYPE : uint
    {
        WINBIO_FP_SENSOR_SUBTYPE_TOUCH = 0x00000002,
        WINBIO_FP_SENSOR_SUBTYPE_SWIPE = 0x00000001,
        WINBIO_SENSOR_SUBTYPE_UNKNOWN = 0x00000000
    }
}
