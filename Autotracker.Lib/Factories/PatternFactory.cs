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
        public IPattern Get()
        {
            return new Pattern();
        }
    }
}
