using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class MajorPentatonicKey : GenericOctaveKey
    {
        private readonly bool[] _keyMask = { true, false, true, false, true, false, false, true, false, true, false, false };

        protected override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
