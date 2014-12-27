using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using WinBioWrapper.Types;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntPtr handleSession = IntPtr.Zero;
            uint NativeResult = 0;
            uint UnitId = 0;
            WINBIO_REJECT_DETAIL RejectDetail = 0;
            IntPtr Sample = IntPtr.Zero;
            int SampleSize = 0;
            Byte[] sampleContent;
            WINBIO_BIR sampleBIR = new WINBIO_BIR();

            NativeResult = WinBio.Native.WinBioOpenSession(WINBIO_BIOMETRIC_TYPE.WINBIO_TYPE_FINGERPRINT, WINBIO_POOL_TYPE.WINBIO_POOL_SYSTEM, WINBIO_SESSION_FLAGS.WINBIO_FLAG_RAW,
                                                           IntPtr.Zero, 0, /*DatabaseID*/1, ref handleSession);

            if (NativeResult != 0)
            {
                //Error 
                return;
            }
            NativeResult = WinBio.Native.WinBioCaptureSample(handleSession,WINBIO_BIR_PURPOSE.WINBIO_NO_PURPOSE_AVAILABLE,WINBIO_BIR_DATA_FLAGS.WINBIO_DATA_FLAG_RAW,
                                            ref UnitId,ref Sample,ref SampleSize,ref RejectDetail);
            if(NativeResult == 0)
            {
                if (Sample != IntPtr.Zero)
                {
                    
                    sampleBIR = (WINBIO_BIR)Marshal.PtrToStructure(Sample, typeof(WINBIO_BIR));
                    sampleContent = new byte[sampleBIR.StandardDataBlock.Size];
                    Marshal.Copy(Sample + (int)sampleBIR.StandardDataBlock.Offset, sampleContent, 0, (int)sampleBIR.StandardDataBlock.Size);
                    string outstr = BitConverter.ToString(sampleContent);
                    Console.Write("Sample Content: " + outstr);
                    WinBio.Native.WinBioFree(Sample);
                }
            }

            if (handleSession != IntPtr.Zero)
            {
                WinBio.Native.WinBioCloseSession(handleSession);
                handleSession = IntPtr.Zero;
            }
        }
    }
}
