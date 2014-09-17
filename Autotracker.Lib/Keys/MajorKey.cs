using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class MajorKey : GenericOctaveKey
    {
        public override KeyType KeyType { get { return KeyType.Major; } }
        private readonly bool[] _keyMask = { true, false, 
                                             true, false,
                                             true,
                                             true, false,
                                             true, false,
                                             true, false,
                                             true };

        public override GenericOctaveKey Clone()
        {
            return (MajorKey)MemberwiseClone();
        }

        protected override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
