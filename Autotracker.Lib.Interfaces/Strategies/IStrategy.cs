using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public interface IStrategy
    {
        bool GeneratePattern(IEnumerable<IGenerator> generators, IPattern pattern);
    }
}
