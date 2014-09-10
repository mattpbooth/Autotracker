using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public abstract class GenericOctaveKey : IKey
    {
        public int BaseNote { get; set; }

        public bool HasNote(int Note)
        {
            var index = Math.Max(0, (Note - BaseNote));
            return GetKeyMaskImpl()[index % Definitions._notesInOctave];
        }

        protected abstract bool[] GetKeyMaskImpl();
    }
}
