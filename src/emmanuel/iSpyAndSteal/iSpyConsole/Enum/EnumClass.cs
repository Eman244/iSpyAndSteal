using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpyConsole.Enum
{
    public static class EnumClass
    {
        public enum DigitalProductIdVersion
        {
            /// <summary>
            /// All systems up to Windows 7 (Windows 7 and older versions)
            /// </summary>
            UpToWindows7,
            /// <summary>
            /// Windows 8 and up (Windows 8 and newer versions)
            /// </summary>
            Windows8AndUp
        }
    }
}
