using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public abstract class Generator : IGenerator, IPrototype<Generator>
    {
        public int Size { get; set; }
        public abstract void ApplyNotes(IPattern pattern, IStrategy strategy);

        public abstract Generator Clone();

    }
}
