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
            _strategyFactory = new StrategyFactory
            (
                new StubIRandomInt(),
                new StubIRandomDouble(),
                new StubIRegistryFactory<IKey, KeyType>(),
                new StubIRegistryFactory<KeySequenceVariant, KeyType>()
            );
            _strategy = _strategyFactory.Get();
        }
    }
}
