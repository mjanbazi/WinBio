using System;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct VERIFY_CALLBACK_CONTEXT
    {
        public WINBIO_BIOMETRIC_SENSOR_SUBTYPE SensorType;
    }
}
