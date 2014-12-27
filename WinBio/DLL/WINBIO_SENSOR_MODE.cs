using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    internal enum WINBIO_SENSOR_MODE : uint
    {
        WINBIO_SENSOR_UNKNOWN_MODE = 0,
        WINBIO_SENSOR_BASIC_MODE = 1,
        WINBIO_SENSOR_ADVANCED_MODE = 2,
        WINBIO_SENSOR_NAVIGATION_MODE = 3,
        WINBIO_SENSOR_SLEEP_MODE = 4
    }
}
