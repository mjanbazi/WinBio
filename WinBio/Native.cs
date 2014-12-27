using System;
using System.Runtime.InteropServices;
using WinBioWrapper.Types;

namespace WinBio
{
     public  class Native
    {
        // http://msdn.microsoft.com/en-us/library/ee221189(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioAcquireFocus();

        // http://msdn.microsoft.com/en-us/library/dd401602(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioCancel(IntPtr SessionHandle);

        // http://msdn.microsoft.com/en-us/library/dd401603(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioCaptureSample(IntPtr SessionHandle, WINBIO_BIR_PURPOSE purpose,
            WINBIO_BIR_DATA_FLAGS Flags, ref uint UnitId, ref IntPtr Sample, ref int SampleSize,
            ref WINBIO_REJECT_DETAIL RejectDetail);

        // http://msdn.microsoft.com/en-us/library/dd401603(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioCaptureSample(IntPtr SessionHandle, WINBIO_BIR_PURPOSE purpose,
            WINBIO_BIR_DATA_FLAGS Flags, ref uint UnitId, ref WINBIO_BIR Sample, ref int SampleSize,
            ref WINBIO_REJECT_DETAIL RejectDetail);

        // http://msdn.microsoft.com/en-us/library/dd401605(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioCloseSession(IntPtr SessionHandle);

        // http://msdn.microsoft.com/en-us/library/dd401606(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioControlUnit(IntPtr SessionHandle, uint UnitId,
            WINBIO_COMPONENT Component, uint ControlCode, IntPtr SendBuffer, int SendBufferSize,
            IntPtr ReceiveBuffer, int ReceiveBufferSize, ref int ReceiveDataSize, ref uint OperationStatus);

        // http://msdn.microsoft.com/en-us/library/dd401607(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioControlUnitPrivileged(IntPtr SessionHandle, uint UnitId,
            WINBIO_COMPONENT Component, uint ControlCode, IntPtr SendBuffer, int SendBufferSize,
            IntPtr ReceiveBuffer, int ReceiveBufferSize, ref int ReceiveDataSize, ref uint OperationStatus);

        // http://msdn.microsoft.com/en-us/library/dd401608(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioDeleteTemplate(IntPtr SessionHandle, uint UnitId,
            WINBIO_IDENTITY Identity, WINBIO_BIOMETRIC_SUBTYPE SubFactor);

        // http://msdn.microsoft.com/en-us/library/dd401617(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioEnrollBegin(IntPtr SessionHandle, WINBIO_BIOMETRIC_SUBTYPE SubFactor,
            uint UnitId);

        // http://msdn.microsoft.com/en-us/library/dd401618(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioEnrollCapture(IntPtr SessionHandle, ref WINBIO_REJECT_DETAIL RejectDetail);

        // http://msdn.microsoft.com/en-us/library/dd401620(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioEnrollCommit(IntPtr SessionHandle,
            ref WINBIO_IDENTITY Identity, ref bool IsNewTemplate);

        // http://msdn.microsoft.com/en-us/library/dd401621(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioEnrollDiscard(IntPtr SessionHandle);

        // http://msdn.microsoft.com/en-us/library/dd401622(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioEnumBiometricUnits(WINBIO_BIOMETRIC_TYPE Factor, ref IntPtr UnitSchemaArray,
            ref int UnitCount);

        // http://msdn.microsoft.com/en-us/library/dd401623(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioEnumDatabases(WINBIO_BIOMETRIC_TYPE Factor, ref IntPtr StorageSchemaArray,
            ref int StorageCount);

        // http://msdn.microsoft.com/en-us/library/dd401624(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioEnumEnrollments(IntPtr SessionHandle, uint UnitId, WINBIO_IDENTITY Identity,
            ref IntPtr SubFactorArray, ref int SubFactorCount);

        // http://msdn.microsoft.com/en-us/library/dd401625(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioEnumServiceProviders(WINBIO_BIOMETRIC_TYPE Factor, ref IntPtr BspSchemaArray,
            ref int BspCount);

        // http://msdn.microsoft.com/en-us/library/dd401626(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioFree(IntPtr Address);

        // http://msdn.microsoft.com/en-us/library/dd401627(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioGetCredentialState(WINBIO_IDENTITY Identity, WINBIO_CREDENTIAL_TYPE Type,
            ref WINBIO_CREDENTIAL_STATE CredentialState);

        // http://msdn.microsoft.com/en-us/library/dd560903(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioGetDomainLogonSetting(ref bool Value, ref WINBIO_SETTING_SOURCE_TYPE Source);

        // http://msdn.microsoft.com/en-us/library/dd560904(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioGetEnabledSetting(ref bool Value, ref WINBIO_SETTING_SOURCE_TYPE Source);

        // http://msdn.microsoft.com/en-us/library/dd560905(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioGetLogonSetting(ref bool Value, ref WINBIO_SETTING_SOURCE_TYPE Source);

        // http://msdn.microsoft.com/en-us/library/ee221190(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioGetProperty(IntPtr SessionHandle, WINBIO_PROPERTY_TYPE PropertyType,
            uint PropertyId, [Optional()]uint UnidId, [Optional()]WINBIO_IDENTITY Identity,
              [Optional()]WINBIO_BIOMETRIC_SUBTYPE SubFactor, ref IntPtr PropertyBuffer, ref int PropertyBufferSize);

        // http://msdn.microsoft.com/en-us/library/dd401628(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioIdentify(IntPtr SessionHandle, ref uint UnitId, ref WINBIO_IDENTITY Identity,
            ref WINBIO_BIOMETRIC_SUBTYPE SubFactor, ref WINBIO_REJECT_DETAIL RejectDetail);

       
        // http://msdn.microsoft.com/en-us/library/dd401630(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioLocateSensor(IntPtr SessionHandle, ref uint UnitId);

        // http://msdn.microsoft.com/en-us/library/dd401632(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioLockUnit(IntPtr SessionHandle, uint UnitId);

        // http://msdn.microsoft.com/en-us/library/dd401633(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioLogonIdentifiedUser(IntPtr SessionHandle);

        // http://msdn.microsoft.com/en-us/library/dd401634(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioOpenSession(WINBIO_BIOMETRIC_TYPE Factor, WINBIO_POOL_TYPE PoolType,
            WINBIO_SESSION_FLAGS Flags, IntPtr UnitArray, int UnitCount, int DatabaseId, ref IntPtr SessionHandle);

        // http://msdn.microsoft.com/en-us/library/ee221191(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioReleaseFocus();

        // http://msdn.microsoft.com/en-us/library/dd401636(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioRemoveAllCredentials();

        // http://msdn.microsoft.com/en-us/library/dd401637(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioRemoveAllDomainCredentials();

        // http://msdn.microsoft.com/en-us/library/dd401638(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioRemoveCredential(WINBIO_IDENTITY Identity, WINBIO_CREDENTIAL_TYPE Type);

        // http://msdn.microsoft.com/en-us/library/dd401639(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioSetCredential(WINBIO_CREDENTIAL_TYPE Type, IntPtr Credential,
            int CredentialSize, WINBIO_CREDENTIAL_FORMAT Format);

        // http://msdn.microsoft.com/en-us/library/dd401640(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioUnlockUnit(IntPtr SessionHandle, uint UnitId);

        // http://msdn.microsoft.com/en-us/library/dd401641(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioUnregisterEventMonitor(IntPtr SessionHandle);

        // http://msdn.microsoft.com/en-us/library/dd401642(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioVerify(IntPtr SessionHandle, WINBIO_IDENTITY Identity,
            WINBIO_BIOMETRIC_SENSOR_SUBTYPE SubFactor, ref uint UnitId, ref bool Match,
            ref WINBIO_REJECT_DETAIL RejectDetail);

       
        // http://msdn.microsoft.com/en-us/library/dd401644(VS.85).aspx
        [DllImport("Winbio.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint WinBioWait(IntPtr SessionHandle);

      
    }
}
