using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class KeySequenceFactory : IRegistryFactory<KeySequenceVariant, KeyType>
    {
        Dictionary<KeyType, IEnumerable<KeySequenceVariant>> _registry = new Dictionary<KeyType, IEnumerable<KeySequenceVariant>>();

        // 4 seems to be the relationship between block size and pattern size (e.g. 128/32 = 4)
        // TODO: Remove this dependency.
        const int _sequencesPerVarient = 4;

        IRandomInt _random;

        public KeySequenceFactory(IRandomInt random)
        {
            _random = random;

            // This should be data driven as soon as concept is proven.
            var majorSequenceVarients = new List<KeySequenceVariant>();
            var majorSequence1 = new KeySequence[_sequencesPerVarient];
            majorSequence1[0] = new KeySequence { Note = 0, KeyType = KeyType.Major };
            majorSequence1[1] = new KeySequence { Note = -5, KeyType = KeyType.Major };
            majorSequence1[2] = new KeySequence { Note = -3, KeyType = KeyType.Minor };
            majorSequence1[3] = new KeySequence { Note = 5, KeyType = KeyType.Major };

            var majorSequence2 = new KeySequence[_sequencesPerVarient];
            majorSequence2[0] = new KeySequence { Note = 0, KeyType = KeyType.Major };
            majorSequence2[1] = new KeySequence { Note = 0, KeyType = KeyType.Major };
            majorSequence2[2] = new KeySequence { Note = -7,KeyType = KeyType.Minor };
            majorSequence2[3] = new KeySequence { Note = -5, KeyType = KeyType.Major };

            var minorSequence1 = new KeySequence[_sequencesPerVarient];
            minorSequence1[0] = new KeySequence { Note = 0, KeyType = KeyType.Minor };
            minorSequence1[1] = new KeySequence { Note = -4, KeyType = KeyType.Major };
            minorSequence1[2] = new KeySequence { Note = 5, KeyType = KeyType.Major };
            minorSequence1[3] = new KeySequence { Note = -2, KeyType = KeyType.Major };

            var minorSequence2 = new KeySequence[_sequencesPerVarient];
            minorSequence2[0] = new KeySequence { Note = 0, KeyType = KeyType.Minor };
            minorSequence2[1] = new KeySequence { Note = -2, KeyType = KeyType.Major };
            minorSequence2[2] = new KeySequence { Note = -4, KeyType = KeyType.Major };
            minorSequence2[3] = new KeySequence { Note = -5, KeyType = KeyType.Minor };
           
            var majorSequenceVariants = new List<KeySequenceVariant>();
            var minorSequenceVariants = new List<KeySequenceVariant>();

            majorSequenceVariants.Add( new KeySequenceVariant{ KeySequences = majorSequence1 });
            majorSequenceVariants.Add( new KeySequenceVariant{ KeySequences = majorSequence2 });
            minorSequenceVariants.Add( new KeySequenceVariant{ KeySequences = minorSequence1 });
            minorSequenceVariants.Add( new KeySequenceVariant{ KeySequences = minorSequence2 });
            
            _registry.Add(KeyType.Major, majorSequenceVariants);
            _registry.Add(KeyType.Minor, minorSequenceVariants);
        }

        public KeySequenceVariant GetByKey(KeyType keyType)
        {
            var keySequence = _registry[keyType];
            var choice = _random.Choice(keySequence);
            return choice;
        }

        public IEnumerable<KeySequenceVariant> GetAll()
        {
            return _registry.SelectMany(x => x.Value);
        }
    }
}
