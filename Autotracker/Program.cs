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

            // Setting up tests firstly... ignore, this was exploratory, and got quite messy.
            // The original project has a lot of hardcoded values and passes a lot of args.
            // Felt like I needed to do the below before getting a better abstraction picture.
            
            // DI
            //SamplerFactory samplerFactory;
            //Tracker tracker = new ImpulseTrackerTracker();

            //Console.Write("Generating Samples");
            //var guitarSampler = samplerFactory.Get(SamplerType.Guitar);
            //var bassSampler = samplerFactory.Get(SamplerType.Bass);
            //var kickSampler = samplerFactory.Get(SamplerType.Kick);
            //var hiHatClosedSampler = samplerFactory.Get(SamplerType.HiHatClosed);
            //var hiHatOpenSampler = samplerFactory.Get(SamplerType.HiHatOpen);
            //var snareSampler = samplerFactory.Get(SamplerType.Snare);

            //Console.Write("Generating Patterns");
            //var random = new Random();

            //var strategy = StrategyFactory.Get();

            //strategy.Generators.Add(
            //    new DrumsGenerator
            //    {
            //        Kick = kickSampler,
            //        Snare = snareSampler,
            //        HiHatClosed = hiHatClosedSampler,
            //        HiHatOpen = hiHatClosedSampler
            //    });

            //strategy.Generators.Add(
            //    new AmbientMelodyGenerator
            //    {
            //        Sampler = guitarSampler
            //    });

            //strategy.Generators.Add(
            //    new BassGenerator
            //    {
            //        Sampler = bassSampler
            //    });

            //for(int i = 0; i <= 5;++i)
            //{
            //    tracker.AddPattern(strategy);
            //}

            //Console.Write("Generated Patterns");

            //tracker.Name = "Test.it";
            //tracker.Save();
            //Console.Write("Saving");

            //Console.Write("Done!");
        }
    }
}
