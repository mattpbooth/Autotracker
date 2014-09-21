using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class KeyFactory : PrototypeRegistryFactory<IKey, KeyType>
    {
        const int _baseNote = 60;
        public KeyFactory(int baseNote = _baseNote)
        {
            _registry.Add(KeyType.Major, new MajorKey(baseNote));
            _registry.Add(KeyType.Minor, new MinorKey(baseNote));
            _registry.Add(KeyType.MajorPentatonic, new MajorPentatonicKey(baseNote));
            _registry.Add(KeyType.MinorPentatonic, new MinorPentatonicKey(baseNote));
        }
    }
}
