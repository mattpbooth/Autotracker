using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autotracker.Lib;
using Autotracker.Lib.Interfaces;

namespace Autotracker.Test.Strategies
{
    [TestClass]
    public class StrategyTests
    {
        IStrategy _strategy;

        [TestInitialize]
        public void Setup()
        {
            // TODO: DI
            _strategy = StrategyFactory.Get();
        }

        [TestMethod]
        public void AddGeneratorSuccess()
        {
           // _strategy.AddGenerator(new IGenerator());
            throw new NotImplementedException();
        }

        [TestMethod]
        public void AddMoreThanOneGeneratorSuccess()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GeneratePatternSuccess()
        {
            throw new NotImplementedException();
        }
    }
}
