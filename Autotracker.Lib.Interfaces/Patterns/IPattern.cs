using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public interface IPattern
    {
        byte[] Data { get; set; }
        int Rows { get; set; }
    }
}
