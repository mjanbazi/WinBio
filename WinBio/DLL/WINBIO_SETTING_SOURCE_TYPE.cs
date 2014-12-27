using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    public enum WINBIO_SETTING_SOURCE_TYPE : uint
    {
        WINBIO_SETTING_SOURCE_INVALID = 0,
        WINBIO_SETTING_SOURCE_DEFAULT = 1,
        WINBIO_SETTING_SOURCE_POLICY = 2,
        WINBIO_SETTING_SOURCE_LOCAL = 3
    }
}
