using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    /// <summary>
    /// Tracker pattern, series of notes and parameters.
    /// e.g. https://code.google.com/p/klystrack/wiki/PatternEditor
    /// </summary>
    public class Pattern : IPattern
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public Pattern(int id, int size)
        {
            Id = id;
            Size = size;
        }
    }
}
