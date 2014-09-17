using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public enum KeyType
    {
        Generic,
        Major,
        Minor,
        MajorPentatonic,
        MinorPentatonic
    }

    public interface IKey
    {
        KeyType KeyType { get; }
        int BaseNote { get; set; }
        bool HasNote(int Note);
    }
}

