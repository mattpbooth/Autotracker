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

    public class SamplerFactory : PrototypeRegistryFactory<Sampler, SamplerType>
    {
        public SamplerFactory()
        {
            // TODO: Need to handle the base prototype values also...
            // TODO: Not nice hardcoding this, move to a repository...
            _registry.Add
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
            _registry.Add
            (
                SamplerType.Kicker,
                new KickerSampler.KickerSamplerBuilder()
                    .WithName("Kick")
                    .Build()
            );
            _registry.Add
            (
                SamplerType.Bass,
                new KarplusStrongSynthSampler.KarplusStrongSynthSamplerBuilder()
                    .WithDecay(0.005f)
                    .WithFrequencyMultiply(0.5f)
                    .WithFilter0(0.2f)
                    .WithFilterN(0.2f)
                    .WithFilterF(0.005f)
                    .WithFilterDC(0.01f)
                    .WithLengthInSeconds(0.7f)
                    .WithName("KS Bass")
                    .WithFrequency(Definitions._middleC / 4.0f)
                    .Build()
            );
            _registry.Add
            (
                SamplerType.HiHatClosed,
                new NoiseHitSampler.NoiseHitSamplerBuilder()
                    .WithDecay(0.03f)
                    .WithFilterL(0.99f)
                    .WithFilterH(0.2f)
                    .WithName("NH Hihat Closed")
                    .WithGlobalVolume(32)
                    .Build()
            );
            _registry.Add
            (
                SamplerType.HiHatOpen,
                new NoiseHitSampler.NoiseHitSamplerBuilder()
                    .WithDecay(0.5f)
                    .WithFilterL(0.99f)
                    .WithFilterH(0.2f)
                    .WithName("NH Hihat Open")
                    .WithGlobalVolume(32)
                    .Build()
            );
            _registry.Add
            (
                SamplerType.Snare,
                new NoiseHitSampler.NoiseHitSamplerBuilder()
                    .WithDecay(0.12f)
                    .WithFilterL(0.15f)
                    .WithFilterH(0.149f)
                    .WithName("NH Snare")
                    .WithGlobalVolume(32)
                    .Build()
            );
        }
    }
}
