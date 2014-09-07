using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    // Not too fond of using this, would like something more dynamic. Maybe if/when I move to a repository for state.
    public enum SamplerType
    {
        Guitar,
        Bass,
        Kicker,
        HiHatOpen,
        HiHatClosed,
        Snare
    }

    public class SamplerFactory : IRegistryFactory<Sampler, SamplerType>
    {
        private Dictionary<SamplerType, Sampler> _samplerRegistry = new Dictionary<SamplerType, Sampler>();
        
        public SamplerFactory()
        {
            // TODO: Need to handle the base prototype values also...
            // TODO: Not nice hardcoding this, move to a repository.
            _samplerRegistry.Add
            (
                SamplerType.Guitar,
                new KarplusStrongSynthSampler.KarplusStrongSynthSamplerBuilder()
                    .WithDecay(0.005f)
                    .WithFrequencyMultiply(1.0f)
                    .WithFilter0(0.0f)
                    .WithFilterN(0.6f)
                    .WithFilterF(0.004f)
                    .WithFilterDC(0.01f)
                    .WithLengthInSeconds(1.0f)
                    .WithName("KS Guitar")
                    .WithFrequency(Definitions._middleC)
                    .Build()
            );
            _samplerRegistry.Add
            (
                SamplerType.Kicker,
                new KickerSampler.KickerSamplerBuilder()
                    .WithName("Kick")
                    .Build()
            );
        }

        public Sampler GetByKey(SamplerType key)
        {
            Sampler sampler;
            if (_samplerRegistry.TryGetValue(key, out sampler))
            {
                return sampler.Clone();
            }
            return null;
        }
    }
}
