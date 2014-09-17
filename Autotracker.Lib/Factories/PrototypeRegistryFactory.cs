using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class PrototypeRegistryFactory<T, U> : IRegistryFactory<T, U> where T: IPrototype<T>
    {
        protected Dictionary<U, T> _registry = new Dictionary<U, T>();
        public virtual T GetByKey(U key)
        {
            T value;
            if (_registry.TryGetValue(key, out value))
            {
                return value.Clone();
            }
            return default(T);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _registry.Select( x => x.Value.Clone() );
        }
    }
}
