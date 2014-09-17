using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    public class TrackerFactory : IFactory<Tracker>
    {
        IFactory<IStrategy> _strategyFactory;
        IRegistryFactory<IGenerator, GeneratorType> _generatorFactory;
        IFactory<IPattern> _patternFactory;

        public TrackerFactory(IFactory<IStrategy> strategyFactory, IRegistryFactory<IGenerator, GeneratorType> generatorFactory, IFactory<IPattern> patternFactory)
        {
            _strategyFactory = strategyFactory;
            _generatorFactory = generatorFactory;
            _patternFactory = patternFactory;
        }

        public Tracker Get()
        {
            return new Tracker(_strategyFactory.Get(),
                               _patternFactory,
                               _generatorFactory);
        }
    }
}
