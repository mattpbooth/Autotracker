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

        public GeneratorFactory()
        {
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
