using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    

    public struct KeySequence
    {
        public int Note{get;set;}
        public IKey Key{get;set;}
    }
    public struct KeySequenceVariant
    {
        public KeySequence[] KeySequences{get;set;}
    }
}
