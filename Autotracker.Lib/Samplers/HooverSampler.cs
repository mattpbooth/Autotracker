using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class HooverSampler : Sampler
    {
        public HooverSampler(ISamplerConfigurationFactory samplerConfiguration, string name)
            : base(samplerConfiguration, name)
        {
        }

        // Sampler
        protected override List<float> GenerateImpl()
        {
            throw new NotImplementedException();
        }
    }
}
