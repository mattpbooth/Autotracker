using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public abstract class SingleSamplerGenerator: Generator
    {
        protected ISampler _sampler;

        public SingleSamplerGenerator(ISampler sampler)
        {
            _sampler = sampler;
        }
    }
}
