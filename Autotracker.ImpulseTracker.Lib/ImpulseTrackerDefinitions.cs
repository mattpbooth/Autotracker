using Autotracker.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.ImpulseTracker.Lib
{
    public enum Convert
    {
        Signed = 1 << 0,
        Bigend = 1 << 1,
        Delta = 1 << 2,
        ByteDelta = 1 << 3,
        TxWave = 1 << 4,
        Stereo = 1 << 5
    }
}
