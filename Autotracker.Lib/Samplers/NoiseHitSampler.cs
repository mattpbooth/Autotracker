using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class NoiseHitSampler : Sampler
    {
        public float GlobalVolume { get; set; }
        public float Decay{get; set;}
        public float FilterL{get; set;}
        public float FilterH { get;  set; }

        public NoiseHitSampler(ISamplerConfigurationFactory samplerConfiguration, string name)
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
