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
            return GetKeyMaskImpl()[(Note - BaseNote) % Definitions._notesInOctave];
        }

        protected abstract bool[] GetKeyMaskImpl();
    }
}
