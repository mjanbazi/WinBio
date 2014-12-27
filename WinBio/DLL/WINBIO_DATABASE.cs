using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinBioWrapper.Types
{
    public enum WINBIO_DATABASE : uint
    {
        WINBIO_DATABASE_TYPE_FILE = 0x00000001,
        WINBIO_DATABASE_TYPE_DBMS = 0x00000002,
        WINBIO_DATABASE_TYPE_ONCHIP = 0x00000003,
        WINBIO_DATABASE_TYPE_SMARTCARD = 0x00000004,
        WINBIO_DATABASE_FLAG_MASK = 0xFFFF0000,
        WINBIO_DATABASE_FLAG_REMOVABLE = 0x00010000,
        WINBIO_DATABASE_FLAG_REMOTE = 0x00020000
    }
}
