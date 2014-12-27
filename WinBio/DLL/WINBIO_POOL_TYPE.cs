using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    public enum WINBIO_POOL_TYPE : uint
    {
        WINBIO_POOL_UNKNOWN = 0,
        WINBIO_POOL_SYSTEM = 1,
        WINBIO_POOL_PRIVATE = 2
    }
}
