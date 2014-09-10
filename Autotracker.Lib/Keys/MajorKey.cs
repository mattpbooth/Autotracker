using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class MajorKey : GenericOctaveKey
    {
        private readonly bool[] _keyMask = { true, false, 
                                             true, false,
                                             true,
                                             true, false,
                                             true, false,
                                             true, false,
                                             true };

        protected override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
