using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autotracker.Lib;
using Autotracker.Lib.Interfaces;
using Autotracker.Lib.Interfaces.Fakes;

namespace Autotracker.Lib.Test.Unit
{
    [TestClass]
    public class StrategyTests
    {
        private StrategyFactory _strategyFactory;
        private IStrategy _strategy;

        [TestInitialize]
        public void Setup()
        {
            // Might get a DI framework for this... Unity?
            _strategyFactory = new StrategyFactory
            {
                 _majorKey = new StubIKey(),
                 _minorKey = new StubIKey(),
                 _randomInt = new StubIRandom<int>(),
                 _randomDouble = new StubIRandom<double>()
            };
            _strategy = _strategyFactory.Get();
        }

        [TestMethod]
        public void AddGeneratorSuccess()
        {
            Assert.AreEqual(_strategy.AddGenerator(new StubIGenerator()), 1);
        }

        [TestMethod]
        public void AddTwoGeneratorSuccess()
        {
            _strategy.AddGenerator(new StubIGenerator());
            Assert.AreEqual(_strategy.AddGenerator(new StubIGenerator()), 2);
        }

        [TestMethod]
        public void GeneratePatternNoGeneratorFailure()
        {
            Assert.IsFalse(_strategy.GeneratePattern(new StubIPattern()));
        }

        [TestMethod]
        public void GeneratePatternSuccess()
        {
            _strategy.AddGenerator(new StubIGenerator());
            Assert.IsTrue(_strategy.GeneratePattern(new StubIPattern()));
        }

        [TestMethod]
        public void GeneratePredictablePatternSuccess()
        {
            // Requires the random stub to return a set of predictable values...
            throw new NotImplementedException();
        }
    }
}
