using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class NoiseHitSamplerBuilder : SamplerBuilder<NoiseHitSampler>
    {
        public NoiseHitSamplerBuilder(ISamplerConfigurationFactory configurationFactory, string name)
            : base(configurationFactory, name)
        {
        }

        public NoiseHitSamplerBuilder WithGlobalVolume(float globalVolume)
        {
            _sampler.GlobalVolume = globalVolume;
            return this;
        }

        public NoiseHitSamplerBuilder WithDecay(float decay)
        {
            _sampler.Decay = decay;
            return this;
        }

        public NoiseHitSamplerBuilder WithFilterL(float filterL)
        {
            _sampler.FilterL = filterL;
            return this;
        }

        public NoiseHitSamplerBuilder WithFilterH(float filterH)
        {
            _sampler.FilterH = filterH;
            return this;
        }
    }
}
