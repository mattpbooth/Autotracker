using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public static class KeyMasks
    {
        public static bool[] GenericOctave = { true, true, true, true, true, true, true, true, true, true, true, true };
        public static bool[] Major = { true, false, true, false, true, true, false, true, false, true, false, true };
        public static bool[] Minor = { true, false, true, true, false, true, false, true, true, false, true, false };
        public static bool[] MajorPentatonic = { true, false, true, false, true, false, false, true, false, true, false, false };
        public static bool[] MinorPentatonic = { true, false, false, true, false, true, false, true, false, false, true, false };
    }
}
