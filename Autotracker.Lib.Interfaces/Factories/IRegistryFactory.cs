using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Interfaces
{
    public interface IRegistryFactory<T, U>
    {
        T GetByKey(U key);
        IEnumerable<T> GetAll();
    }
}
