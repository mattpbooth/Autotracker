using Autotracker.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib
{
    /// <summary>
    /// Orchestrator for generation of tracker data.
    /// Tracker-specific implementations to be derived.
    /// </summary>
    public class Tracker : ITracker
    {
        IStrategy _strategy;
        IEnumerable<IGenerator> _generators;
        IFactory<IPattern> _patternFactory;

        public Tracker(IStrategy strategy, IFactory<IPattern> patternFactory, IRegistryFactory<IGenerator, GeneratorType> generatorFactory)
        {
            _strategy = strategy;
            _generators = generatorFactory.GetAll();
            _patternFactory = patternFactory;
        }

        public virtual void Generate()
        {
            _strategy.GeneratePattern(_generators, _patternFactory.Get());
        }
    }
}
