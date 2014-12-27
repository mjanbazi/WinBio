using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    public enum WINBIO_SESSION_FLAGS : uint
    {
        WINBIO_FLAG_DEFAULT = 0x00000000,
        WINBIO_FLAG_BASIC = (WINBIO_SENSOR_MODE.WINBIO_SENSOR_BASIC_MODE & 0xFFFF) << 16,
        WINBIO_FLAG_ADVANCED = (WINBIO_SENSOR_MODE.WINBIO_SENSOR_ADVANCED_MODE & 0xFFFF) << 16,
        WINBIO_FLAG_RAW = BIO_UNIT.BIO_UNIT_RAW,
        WINBIO_FLAG_MAINTENANCE = BIO_UNIT.BIO_UNIT_MAINTENANCE
    }
}
