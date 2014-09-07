using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class MinorPentatonicKey : GenericOctaveKey
    {
        private readonly bool[] _keyMask = { true, false, true, true, false, true, false, true, true, false, true, false };

        protected override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
