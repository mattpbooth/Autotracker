using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public interface IStrategy
    {
        void GeneratePattern(IPattern pattern);
        void AddGenerator(IGenerator generator);
    }
}
