using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autotracker.Lib;
using Autotracker.Lib.Interfaces;
using Autotracker.Lib.Interfaces.Fakes;
using System.Collections.Generic;

namespace Autotracker.Lib.Test.Unit
{
    [TestClass]
    public class StrategyTests
    {
        private StrategyFactory _strategyFactory;
        private IStrategy _strategy;
        private IFactory<IPattern> _patternFactory;

        [TestInitialize]
        public void Setup()
        {
            _strategyFactory = new StrategyFactory
            (
                new StubIRandomInt()
                {
                    GetNextRangeInt32Int32 = (int min, int max) => {return max;}
                },
                new StubIRandomDouble(),
                new StubIRegistryFactory<IKey, KeyType>(),
                new StubIRegistryFactory<KeySequenceVariant, KeyType>()
            );
            _strategy = _strategyFactory.Get();
            _patternFactory = new StubIFactory<IPattern>()
            {
                Get = () => { return new Pattern(0, 128); }
            };
        }

        [TestMethod]
        public void TestStrategyPatternGenerationNoGeneratorFailure()
        {
            var generatorFactory = new StubIRegistryFactory<IGenerator, GeneratorType>()
            {
                GetAll = () => { return new List<IGenerator>(); }
            };

            Assert.IsFalse(_strategyFactory.Get().GeneratePattern(generatorFactory.GetAll(), _patternFactory.Get()));
        }

        [TestMethod]
        public void TestStrategyPatternGenerationWithGeneratorsSuccess()
        {
            var generators = new List<IGenerator>();
            generators.Add( new StubIGenerator() );
            
            var generatorFactory = new StubIRegistryFactory<IGenerator, GeneratorType>()
            {
                GetAll = () => { return generators; }
            };

            Assert.IsTrue(_strategyFactory.Get().GeneratePattern(generatorFactory.GetAll(), _patternFactory.Get()));
        }

        [TestMethod]
        public void TestStrategyPatternRhythmValidSuccess()
        {
            // I'm sure I'll end up fiddling with this format, so good to have tests to catch my meddling breaking something.
            // Current format looks like the below, with optional numbers of 0s.
            // I'm still not sure what 3 and 1 represent...
            // [3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 
            //  3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 
            //  3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 
            //  3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 
            //  3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 
            // 3, 0, 0, 0, 1, 0, 0, 0]
            var strategy = _strategyFactory.Get();
            var rhythm = strategy.Rhythm;

            int expectedNext = 3;
            foreach(var r in rhythm)
            {
                switch(r)
                {
                    case 3:
                        Assert.AreEqual(expectedNext, 3);
                        expectedNext = 1;
                        break;

                    case 1:
                        Assert.AreEqual(expectedNext, 1);
                        expectedNext = 3;
                        break;

                    case 0:
                        break;

                    default:
                        Assert.Fail("Invalid value found");
                        break;
                }
            }
        }
    }
}
