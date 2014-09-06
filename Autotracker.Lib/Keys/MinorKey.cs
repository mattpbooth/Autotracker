using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Keys
{
    public class MinorKey
    {
        private const bool[] _keyMask = { true, false, true, true, false, true, false, true, true, false, true, false };

        private override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
