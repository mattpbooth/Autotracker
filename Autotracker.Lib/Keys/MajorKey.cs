using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Keys
{
    public class MajorKey : GenericOctaveKey
    {
        private const bool[] _keyMask = { true, false, false, true, false, true, false, true, false, false, true, false };

        private override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
