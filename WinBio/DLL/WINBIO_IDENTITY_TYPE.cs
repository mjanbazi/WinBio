using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    public enum WINBIO_IDENTITY_TYPE : uint
    {
        WINBIO_ID_TYPE_NULL = 0,
        WINBIO_ID_TYPE_WILDCARD = 1,
        WINBIO_ID_TYPE_GUID = 2,
        WINBIO_ID_TYPE_SID = 3
    }
}
