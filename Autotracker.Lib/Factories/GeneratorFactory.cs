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

    public class GeneratorFactory : PrototypeRegistryFactory<IGenerator, GeneratorType>
    {
        public GeneratorFactory(IRegistryFactory<ISampler, SamplerType> samplerFactory)
        {
            _registry.Add(GeneratorType.AmbientMelody, new AmbientMelodyGenerator(samplerFactory.GetByKey(SamplerType.Guitar)));
            _registry.Add(GeneratorType.Bass, new BassGenerator(samplerFactory.GetByKey(SamplerType.Bass)));
            _registry.Add(GeneratorType.Drums, new DrumsGenerator
            (
                samplerFactory.GetByKey(SamplerType.Kicker),
                samplerFactory.GetByKey(SamplerType.Snare),
                samplerFactory.GetByKey(SamplerType.HiHatClosed),
                samplerFactory.GetByKey(SamplerType.HiHatOpen)
            ));
        }
    }
}
