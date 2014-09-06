using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public interface IKey
    {
        int BaseNote { get; set; }
        bool HasNote(int Note);
    }
}

