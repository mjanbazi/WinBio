using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    // http://msdn.microsoft.com/en-us/library/dd401653(VS.85).aspx
    public enum WINBIO_CREDENTIAL_STATE
    {
        WINBIO_CREDENTIAL_NOT_SET = 0x00000001,
        WINBIO_CREDENTIAL_SET = 0x00000002
    }
}
