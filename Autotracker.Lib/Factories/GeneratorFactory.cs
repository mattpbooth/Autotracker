using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public enum GeneratorType
    {
        AmbientMelody,
        Bass,
        Drums
    };

    public class GeneratorFactory : IRegistryFactory<Generator, GeneratorType>
    {
        private Dictionary<GeneratorType, Generator> _generatorRegistry = new Dictionary<GeneratorType, Generator>();

        private GeneratorFactory(ISampler guitarSampler, ISampler bassSampler, ISampler kickSampler, ISampler snareSampler, ISampler hiHatOpenSampler, ISampler hiHatClosedSampler)
        {
            _generatorRegistry.Add(GeneratorType.AmbientMelody, new AmbientMelodyGenerator(guitarSampler));
            _generatorRegistry.Add(GeneratorType.Bass, new BassGenerator(bassSampler));
            _generatorRegistry.Add(GeneratorType.Drums, new DrumsGenerator(kickSampler, snareSampler, hiHatClosedSampler, hiHatOpenSampler));
        }

        public class Builder : IBuilder<GeneratorFactory>
        {
            private ISampler _guitarSampler;
            private ISampler _bassSampler;
            private ISampler _kickSampler;
            private ISampler _snareSampler;
            private ISampler _hiHatOpenSampler;
            private ISampler _hiHatClosedSampler;

            public Builder WithGuitarSampler(ISampler guitarSampler)
            {
                _guitarSampler = guitarSampler;
                return this;
            }

            public Builder WithBassSampler(ISampler bassSampler)
            {
                _bassSampler = bassSampler;
                return this;
            }

            public Builder WithKickSampler(ISampler kickSampler)
            {
                _kickSampler = kickSampler;
                return this;
            }

            public Builder WithSnareSampler(ISampler snareSampler)
            {
                _snareSampler = snareSampler;
                return this;
            }

            public Builder WithHiHatOpenSampler(ISampler hiHatOpenSampler)
            {
                _hiHatOpenSampler = hiHatOpenSampler;
                return this;
            }

            public Builder WithHiHatClosedSampler(ISampler hiHatClosedSampler)
            {
                _hiHatClosedSampler = hiHatClosedSampler;
                return this;
            }

            public GeneratorFactory Build()
            {
                return new GeneratorFactory
                (
                    _guitarSampler,
                    _bassSampler,
                    _kickSampler,
                    _snareSampler,
                    _hiHatOpenSampler,
                    _hiHatClosedSampler
                );
            }
        }

        public Generator GetByKey(GeneratorType key)
        {
            Generator generator;
            if (_generatorRegistry.TryGetValue(key, out generator))
            {
                return generator.Clone();
            }
            return null;
        }
    }
}
