using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class PatternFactory: IFactory<IPattern>
    {
        int _patternId;
        int _patternSize;

        public PatternFactory(int patternSize = 128)
        {
            _patternSize = patternSize;
        }

        public IPattern Get()
        {
            return new Pattern(_patternId++, _patternSize);
        }
    }
}
