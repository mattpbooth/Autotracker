using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    /// <summary>
    /// Will generate samples consistent with a particular instrument's sound.
    /// </summary>
    public interface ISampler : IPrototype<ISampler>
    {
        bool Generate();
    }
}
