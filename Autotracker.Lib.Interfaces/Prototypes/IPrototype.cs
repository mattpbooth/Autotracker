using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    /// <summary>
    /// Must provide a clone of itself, I don't want to get into deep/shallow etc if I can avoid it.
    /// </summary>
    public interface IPrototype<T>
    {
        T Clone();
    }
}
