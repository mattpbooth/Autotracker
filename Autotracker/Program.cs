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
            //IFactory<SamplerConfiguration> samplerConfigurationFactory = new ImpulseTrackerSamplerConfigurationFactory();
            //Tracker tracker = new ImpulseTrackerTracker();

            //Console.Write("Generating Samples");
            //var guitarSampler = new KarplusStrongSynthSamplerBuilder(samplerConfigurationFactory, "KS Guitar")
            //    .WithFrequency(Definitions._middleC)
            //    .WithDecay(0.005f)
            //    .WithNFrequencyMultiply(1.0f)
            //    .WithFilter0(0.0f)
            //    .WithFilterN(0.6f)
            //    .WithFilterF(0.004f)
            //    .WithFilterDC(0.01f)
            //    .WithLengthInSeconds(1.0f)
            //    .Build();

            //var bassSampler = new KarplusStrongSynthSamplerBuilder(samplerConfigurationFactory, "KS Bass")
            //    .WithFrequency(Definitions._middleC / 4.0f)
            //    .WithDecay(0.005f)
            //    .WithNFrequencyMultiply(0.5f)
            //    .WithFilter0(0.2f)
            //    .WithFilterN(0.2f)
            //    .WithFilterF(0.005f)
            //    .WithFilterDC(0.01f)
            //    .WithLengthInSeconds(0.7f)
            //    .Build();

            //var kickSampler = new KickerSampler(samplerConfigurationFactory, "Kick");

            //var hiHatClosedSampler = new NoiseHitSamplerBuilder( samplerConfigurationFactory, "NH Hihat Closed")
            //    .WithGlobalVolume(32)
            //    .WithDecay(0.03f)
            //    .WithFilterL(0.99f)
            //    .WithFilterH(0.2f)
            //    .Build();

            //var hiHatOpenSampler = new NoiseHitSamplerBuilder(samplerConfigurationFactory, "NH Hihat Closed")
            //    .WithGlobalVolume(32)
            //    .WithDecay(0.5f)
            //    .WithFilterL(0.99f)
            //    .WithFilterH(0.2f)
            //    .Build();

            //var snareSampler = new NoiseHitSamplerBuilder(samplerConfigurationFactory, "NH Hihat Closed")
            //    .WithGlobalVolume(32)
            //    .WithDecay(0.12f)
            //    .WithFilterL(0.15f)
            //    .WithFilterH(0.149f)
            //    .Build();

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
