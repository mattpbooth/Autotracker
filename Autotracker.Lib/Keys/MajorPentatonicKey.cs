using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class MajorPentatonicKey : GenericOctaveKey
    {
        public MajorPentatonicKey(int baseNote)
            : base(baseNote)
        {
        }

        public override KeyType KeyType { get { return KeyType.MajorPentatonic; } }
        private readonly bool[] _keyMask = { true, false,
                                             true, false,
                                             true,
                                             false, false,
                                             true, false,
                                             true, false,
                                             false };
        public override IKey Clone()
        {
            return (MajorPentatonicKey)MemberwiseClone();
        }

        protected override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
