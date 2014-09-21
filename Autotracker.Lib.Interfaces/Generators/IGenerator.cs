using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public interface IGenerator : IPrototype<IGenerator>
    {
        int Size { get; set; }
        void ApplyNotes(IPattern pattern, IStrategy strategy, IKey chord);
    }
}
