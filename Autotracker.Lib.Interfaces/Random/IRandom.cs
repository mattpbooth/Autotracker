﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public interface IRandom<T> where T: struct
    {
        T GetNext();
        T GetNextRange(T min, T max);
    }
}
