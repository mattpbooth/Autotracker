using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public interface IRandomInt : IRandom<int>
    {
    }

    public interface IRandomDouble : IRandom<double>
    {
    }

    public interface IRandom<T>
    {
        T GetNext();
        T GetNextRange(T min, T max);

        /// <summary>
        /// Emulates the Python 'random.choice' functionality.
        /// </summary>
        U Choice<U>(IEnumerable<U> choices);
    }
}
