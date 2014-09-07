using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class KarplusStrongSynthSamplerBuilder : SamplerBuilder<KarplusStrongSynthSampler>
    {
        public KarplusStrongSynthSamplerBuilder(IFactory<SamplerConfiguration> configurationFactory, string name) 
            : base(configurationFactory, name)
        {
        }

        public KarplusStrongSynthSamplerBuilder WithFrequency(float frequency)
        {
            _sampler.Frequency = frequency;
            return this;
        }

        public KarplusStrongSynthSamplerBuilder WithDecay(float decay)
        {
            _sampler.Decay = decay;
            return this;
        }

        public KarplusStrongSynthSamplerBuilder WithNFrequencyMultiply(float nFrequencyMultiply)
        {
            _sampler.NFrequencyMultiply = nFrequencyMultiply;
            return this;
        }

        public KarplusStrongSynthSamplerBuilder WithFilter0(float filter0)
        {
            _sampler.Filter0 = filter0;
            return this;
        }

        public KarplusStrongSynthSamplerBuilder WithFilterN(float filterN)
        {
            _sampler.FilterN = filterN;
            return this;
        }

        public KarplusStrongSynthSamplerBuilder WithFilterDC(float filterDC)
        {
            _sampler.FilterDC = filterDC;
            return this;
        }

        public KarplusStrongSynthSamplerBuilder WithFilterF(float filterF)
        {
            _sampler.FilterF = filterF;
            return this;
        }

        public KarplusStrongSynthSamplerBuilder WithLengthInSeconds(float lengthInSeconds)
        {
            _sampler.LengthInSeconds = lengthInSeconds;
            return this;
        }
    }
}
