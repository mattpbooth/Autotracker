using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class MinorPentatonicKey : GenericOctaveKey
    {
        public override KeyType KeyType { get { return KeyType.MinorPentatonic; } }
        private readonly bool[] _keyMask = { true, false,
                                             false,
                                             true, false,
                                             true, false,
                                             true,
                                             false, false,
                                             true, false };

        public override GenericOctaveKey Clone()
        {
            return (MinorPentatonicKey)MemberwiseClone();
        }

        protected override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
