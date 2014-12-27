using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    public enum WINBIO_REJECT_DETAIL : uint
    {
        WINBIO_FP_SUCCESS = 0,
        WINBIO_FP_TOO_HIGH = 1,
        WINBIO_FP_TOO_LOW = 2,
        WINBIO_FP_TOO_LEFT = 3,
        WINBIO_FP_TOO_RIGHT = 4,
        WINBIO_FP_TOO_FAST = 5,
        WINBIO_FP_TOO_SLOW = 6,
        WINBIO_FP_POOR_QUALITY = 7,
        WINBIO_FP_TOO_SKEWED = 8,
        WINBIO_FP_TOO_SHORT = 9,
        WINBIO_FP_MERGE_FAILURE = 10
    }
}
