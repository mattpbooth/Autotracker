using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class GenericOctaveKey : IKey
    {
        int BaseNote { get; set; }

        public bool HasNote(int Note)
        {
            return GetKeyMaskImpl()[(Note - BaseNote) % Definitions._notesInOctave];
        }

        public abstract bool[] GetKeyMaskImpl();
    }
}
