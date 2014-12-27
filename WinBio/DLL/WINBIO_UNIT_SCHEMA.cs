using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WinBioWrapper.Types
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WINBIO_UNIT_SCHEMA
    {
        public uint UnitId;
        public WINBIO_POOL_TYPE PoolType;
        public WINBIO_BIOMETRIC_TYPE BiometricFactor;
        public WINBIO_BIOMETRIC_SENSOR_SUBTYPE SensorSubType;
        public WINBIO_CAPABILITIES Capabilities;
        public WINBIO_STRING DeviceInstanceId;
        public WINBIO_STRING Description;
        public WINBIO_STRING Manufacturer;
        public WINBIO_STRING Model;
        public WINBIO_STRING SerialNumber;
        public WINBIO_VERSION FirmwareVersion;
    }
}
