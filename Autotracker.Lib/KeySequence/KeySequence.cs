using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    

    public class KeySequence
    {
        public int Note{get;set;}
        public KeyType KeyType { get; set; }
    }

    public class KeySequenceVariant : IPrototype<KeySequenceVariant>
    {
        public Stack<KeySequence> KeySequence{get;set;}

        public KeySequenceVariant Clone()
        {
            return (KeySequenceVariant)this.MemberwiseClone();
        }
    }
}
