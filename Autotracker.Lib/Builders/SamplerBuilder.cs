using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public abstract class SamplerBuilder<T> where T : Sampler
    {
        protected T _sampler;

        public SamplerBuilder(ISamplerConfigurationFactory configurationFactory, string name)
        {
            _sampler = (T)Activator.CreateInstance(typeof(T), configurationFactory, name);
        }

        public T Build()
        {
            return _sampler;
        }
    }
}
