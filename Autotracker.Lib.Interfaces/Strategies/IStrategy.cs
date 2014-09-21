using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public interface IStrategy
    {
        int BlockSize { get; set; }
        IKey Key { get; set; }
        IEnumerable<byte> Rhythm { get; set; }

        bool GeneratePattern(IEnumerable<IGenerator> generators, IPattern pattern);
    }
}
