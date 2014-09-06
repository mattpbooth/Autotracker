using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Keys
{
    public class MajorPentatonicKey
    {
        private const bool[] _keyMask = { true, false, true, false, true, false, false, true, false, true, false, false };

        private override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
