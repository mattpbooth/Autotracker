using Autotracker.ImpulseTracker.Lib;
using Autotracker.Lib.Interfaces;
using Autotracker.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Creating Module");

            // TODO: DI this, use Unity?
            var randomInt = new RandomInt();
            var randomDouble = new RandomDouble();
            var keyFactory = new KeyFactory();
            var keySequenceFactory = new KeySequenceFactory(randomInt);
            var samplerFactory = new SamplerFactory();
            var generatorFactory = new GeneratorFactory(samplerFactory);
            var patternFactory = new PatternFactory();
            var strategyFactory = new StrategyFactory(randomInt, randomDouble, keyFactory, keySequenceFactory);

            var tracker = new ImpulseTrackerTracker(new Tracker(strategyFactory.Get(), patternFactory, generatorFactory));
            tracker.Generate();
            
            Console.Write("Done!");
        }
    }
}
