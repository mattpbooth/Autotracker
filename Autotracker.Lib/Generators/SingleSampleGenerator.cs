using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class SingleSamplerGenerator: IGenerator
    {
        private ISampler _sampler;

        public SingleSamplerGenerator(ISampler sampler)
        {
            _sampler = sampler;
        }

        public void ApplyNotes(IPattern pattern, IStrategy strategy)
        {

        }

        public int Size{get; set;}
    }
}
