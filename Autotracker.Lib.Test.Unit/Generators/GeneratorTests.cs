using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autotracker.Lib;
using System.Collections.Generic;
using Autotracker.Lib.Interfaces;
using Autotracker.Lib.Interfaces.Fakes;

namespace Autotracker.Lib.Test.Unit
{
    [TestClass]
    public class GeneratorTests
    {
        GeneratorFactory _generatorFactory;

        [TestInitialize]
        public void Setup()
        {
            _generatorFactory = new GeneratorFactory
                (
                    new StubIRegistryFactory<ISampler, SamplerType> ()
                );
        }

        [TestMethod]
        public void AmbientMelodyGenerateSuccess()
        {
            var ambientMelody = _generatorFactory.GetByKey(GeneratorType.AmbientMelody);
            try 
            {
                ambientMelody.ApplyNotes(new StubIPattern(), new StubIStrategy(), new StubIKey());
            }
            catch(Exception e)
            {
                Assert.Fail("Test failed due to raised error " + e.Message);
            }
        }

        [TestMethod]
        public void BassGenerateSuccess()
        {
            var bass = _generatorFactory.GetByKey(GeneratorType.Bass);
            try
            {
                bass.ApplyNotes(new StubIPattern(), new StubIStrategy(), new StubIKey());
            }
            catch (Exception e)
            {
                Assert.Fail("Test failed due to raised error " + e.Message);
            }
        }

        [TestMethod]
        public void DrumsGenerateSuccess()
        {
            var drums = _generatorFactory.GetByKey(GeneratorType.Drums);
            try
            {
                drums.ApplyNotes(new StubIPattern(), new StubIStrategy(), new StubIKey() );
            }
            catch (Exception e)
            {
                Assert.Fail("Test failed due to raised error " + e.Message);
            }
        }
    }
}
