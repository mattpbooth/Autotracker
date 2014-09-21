using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class MinorKey : GenericOctaveKey
    {
        public MinorKey(int baseNote)
            : base(baseNote)
        {
        }

        public override KeyType KeyType { get { return KeyType.Minor; } }
        private readonly bool[] _keyMask = { true, false, 
                                             true, 
                                             true, false, 
                                             true, false, 
                                             true, 
                                             true, false, 
                                             true, false };

        public override IKey Clone()
        {
            return (MinorKey)MemberwiseClone();
        }

        protected override bool[] GetKeyMaskImpl()
        {
            return _keyMask;
        }
    }
}
