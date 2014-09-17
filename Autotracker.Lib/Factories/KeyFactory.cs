using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class KeyFactory : PrototypeRegistryFactory<GenericOctaveKey, KeyType>
    {
        public KeyFactory()
        {
            _registry.Add(KeyType.Major, new MajorKey());
            _registry.Add(KeyType.Minor, new MinorKey());
            _registry.Add(KeyType.MajorPentatonic, new MajorPentatonicKey());
            _registry.Add(KeyType.MinorPentatonic, new MinorPentatonicKey());
        }
    }
}
