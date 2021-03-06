﻿using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    /// <summary>
    /// Uses sample and pattern to generates notes.
    /// </summary>
    public abstract class Generator : IGenerator
    {
        public int Size { get; set; }
        public abstract void ApplyNotes(IPattern pattern, IStrategy strategy, IKey chord);

        public abstract IGenerator Clone();

    }
}
