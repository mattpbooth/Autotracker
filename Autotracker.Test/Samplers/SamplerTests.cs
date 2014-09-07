using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autotracker.Lib;
using System.Collections.Generic;
using Autotracker.ImpulseTracker.Lib;
using Autotracker.Lib.Interfaces;

namespace Autotracker.Test
{
    [TestClass]
    public class SamplerTests
    {

        // TODO: Fakes
        //Tracker _tracker;
        //IFactory<SamplerConfiguration> _samplerConfigurationFactory;

        //[TestInitialize]
        //public void Setup()
        //{
        //    _tracker = new ImpulseTrackerTracker { Samplers = new List<Sampler>() };
        //    _samplerConfigurationFactory = new ImpulseTrackerSamplerConfigurationFactory();
        //}

        //[TestMethod]
        //public void AddSamplerToTrackerSuccess()
        //{
        //    var samplerCount = _tracker.Samplers.Count;
        //    Assert.AreEqual(samplerCount, 0);
        //    _tracker.Samplers.Add(new KarplusStrongSynthSampler(_samplerConfigurationFactory, "Test"));
        //    samplerCount = _tracker.Samplers.Count;
        //    Assert.AreEqual(samplerCount, 1);
        //}

        //[TestMethod]
        //public void SamplerGenerateSuccess()
        //{
        //    var sampler = new KarplusStrongSynthSampler(_samplerConfigurationFactory, "Test");
        //    Assert.IsTrue(sampler.Generate());
        //}

        //[TestMethod]
        //public void GuitarSamplerGenerateSuccess()
        //{
        //    var guitar = new KarplusStrongSynthSamplerBuilder(_samplerConfigurationFactory, "KS Guitar")
        //        .WithFrequency(Definitions._middleC)
        //        .WithDecay(0.005f)
        //        .WithNFrequencyMultiply(1.0f)
        //        .WithFilter0(0.0f)
        //        .WithFilterN(0.6f)
        //        .WithFilterF(0.004f)
        //        .WithLengthInSeconds(1.0f)
        //        .Build();
        //    Assert.IsTrue(guitar.Generate());
        //}

        //[TestMethod]
        //public void GuitarSamplerGenerateFailure_FrequencyLessThanLength()
        //{
        //    var guitar = new KarplusStrongSynthSamplerBuilder(_samplerConfigurationFactory, "KS Guitar")
        //        .WithFrequency(Definitions._middleC)
        //        .WithLengthInSeconds(0.0001f)
        //        .Build();

        //    bool didThrow = false;
        //    try
        //    {
        //        guitar.Generate();
        //    }
        //    catch(NotSupportedException)
        //    {
        //        didThrow = true;
        //    }
        //    Assert.IsTrue(didThrow);
        //}

        //[TestMethod]
        //public void BassSamplerGenerateSuccess()
        //{
        //    var bass = new KarplusStrongSynthSamplerBuilder(_samplerConfigurationFactory, "KS Bass")
        //        .WithFrequency(Definitions._middleC / 4.0f)
        //        .WithDecay(0.005f)
        //        .WithNFrequencyMultiply(0.5f)
        //        .WithFilter0(0.2f)
        //        .WithFilterN(0.2f)
        //        .WithFilterF(0.005f)
        //        .WithLengthInSeconds(0.7f)
        //        .Build(); 
        //    Assert.IsTrue(bass.Generate());
        //}

        //[TestMethod]
        //public void KickSamplerGenerateSuccess()
        //{
        //    var kick = new KickerSampler( _samplerConfigurationFactory, "Kick" );
        //    Assert.IsTrue(kick.Generate());
        //}

        //[TestMethod]
        //public void HiHatClosedSamplerGenerateSuccess()
        //{
        //    var hiHatClosed = new NoiseHitSamplerBuilder(_samplerConfigurationFactory, "NH Hihat Closed")
        //        .WithGlobalVolume(32)
        //        .WithDecay(0.03f)
        //        .WithFilterL(0.99f)
        //        .WithFilterH(0.2f)
        //        .Build();
        //    Assert.IsTrue(hiHatClosed.Generate());
        //}

        //[TestMethod]
        //public void HiHatOpenSamplerGenerateSuccess()
        //{
        //    var hiHatOpen = new NoiseHitSamplerBuilder(_samplerConfigurationFactory, "NH Hihat Closed")
        //        .WithGlobalVolume(32)
        //        .WithDecay(0.5f)
        //        .WithFilterL(0.99f)
        //        .WithFilterH(0.2f)
        //        .Build(); 
        //    Assert.IsTrue(hiHatOpen.Generate());
        //}

        //public void SnareOpenSamplerGenerateSuccess()
        //{
        //    var snare = new NoiseHitSamplerBuilder(_samplerConfigurationFactory, "NH Hihat Closed")
        //        .WithGlobalVolume(32)
        //        .WithDecay(0.12f)
        //        .WithFilterL(0.15f)
        //        .WithFilterH(0.149f)
        //        .Build(); 
        //    Assert.IsTrue(snare.Generate());
        //}
    }
}
