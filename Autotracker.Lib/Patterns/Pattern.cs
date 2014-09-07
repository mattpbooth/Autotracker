using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class Pattern : IPattern
    {
        public byte[] Data { get; set; }
        public int Rows { get; set; }
    }
}
