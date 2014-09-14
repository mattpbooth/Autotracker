using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Factories
{
    public class KeySequenceFactory : IFactory<Dictionary<IKey, List<KeySequenceVariant>>>
    {
        const int _sequencesPerVarient = 4;
        Dictionary<IKey, List<KeySequenceVariant>> _keySequences = new Dictionary<IKey, List<KeySequenceVariant>>();

        public KeySequenceFactory(IKey majorKey, IKey minorKey)
        {
            // This should be data driven as soon as concept is proven.
            var majorSequenceVarients = new List<KeySequenceVariant>();
            var majorSequence1 = new KeySequence[_sequencesPerVarient];
            majorSequence1[0] = new KeySequence { Note = 0, Key = majorKey };
            majorSequence1[1] = new KeySequence { Note = -5, Key = majorKey };
            majorSequence1[2] = new KeySequence { Note = -3, Key = minorKey };
            majorSequence1[3] = new KeySequence { Note = 5, Key = majorKey };

            var majorSequence2 = new KeySequence[_sequencesPerVarient];
            majorSequence2[0] = new KeySequence { Note = 0, Key = majorKey };
            majorSequence2[1] = new KeySequence { Note = 0, Key = majorKey };
            majorSequence2[2] = new KeySequence { Note = -7,Key = minorKey };
            majorSequence2[3] = new KeySequence { Note = -5, Key = majorKey };

            var minorSequence1 = new KeySequence[_sequencesPerVarient];
            minorSequence1[0] = new KeySequence { Note = 0, Key = minorKey };
            minorSequence1[1] = new KeySequence { Note = -4, Key = majorKey };
            minorSequence1[2] = new KeySequence { Note = 5, Key = majorKey };
            minorSequence1[3] = new KeySequence { Note = -2, Key = majorKey };

            var minorSequence2 = new KeySequence[_sequencesPerVarient];
            minorSequence2[0] = new KeySequence { Note = 0, Key = minorKey };
            minorSequence2[1] = new KeySequence { Note = -2, Key = majorKey };
            minorSequence2[2] = new KeySequence { Note = -4, Key = majorKey };
            minorSequence2[3] = new KeySequence { Note = -5, Key = minorKey };
           
            var majorSequenceVariants = new List<KeySequenceVariant>();
            var minorSequenceVariants = new List<KeySequenceVariant>();

            majorSequenceVariants.Add( new KeySequenceVariant{ KeySequences = majorSequence1 });
            majorSequenceVariants.Add( new KeySequenceVariant{ KeySequences = majorSequence2 });
            minorSequenceVariants.Add( new KeySequenceVariant{ KeySequences = minorSequence1 });
            minorSequenceVariants.Add( new KeySequenceVariant{ KeySequences = minorSequence2 });
            
            _keySequences.Add(majorKey, majorSequenceVariants);
            _keySequences.Add(minorKey, minorSequenceVariants);
        }

        public Dictionary<IKey, List<KeySequenceVariant>> Get()
        {
            return _keySequences;
        }
    }
}
