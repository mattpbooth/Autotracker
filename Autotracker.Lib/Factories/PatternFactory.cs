using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class PatternFactory: IFactory<Pattern>
    {
        public Pattern Get()
        {
            return new Pattern();
        }
    }
}
