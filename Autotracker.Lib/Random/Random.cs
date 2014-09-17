using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using SysRandom = System.Random;

namespace Autotracker.Lib
{
    public class RandomInt : IRandomInt
    {
        private SysRandom _random = new SysRandom();

        public T Choice<T>(IEnumerable<T> choices)
        {
            return choices.ElementAt(_random.Next(0, choices.Count()));
        }

        public int GetNext()
        {
            return _random.Next();
        }

        public int GetNextRange(int min, int max)
        {
            return _random.Next(min, max);
        }
    }

    public class RandomDouble : IRandomDouble
    {
        private SysRandom _random = new SysRandom();

        public T Choice<T>(IEnumerable<T> choices)
        {
            return choices.ElementAt(_random.Next(0, choices.Count()));
        }

        public double GetNext()
        {
            return _random.NextDouble();
        }

        public double GetNextRange(double min, double max)
        {
            // Mul by difference and project onto min
            var nextDouble = (_random.NextDouble() * (max - min)) + min;
            return nextDouble;
        }
    }
}
