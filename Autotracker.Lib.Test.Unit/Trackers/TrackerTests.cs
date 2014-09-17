using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autotracker.Lib;
using Autotracker.Lib.Interfaces;
using Autotracker.Lib.Interfaces.Fakes;

namespace Autotracker.Lib.Test.Unit
{
    [TestClass]
    public class TrackerTests
    {
        private TrackerFactory _trackerFactory;

        [TestInitialize]
        public void Setup()
        {
            _trackerFactory = new TrackerFactory
            (
                new StubIFactory<IStrategy>(),
                new StubIRegistryFactory<IGenerator, GeneratorType>(),
                new StubIFactory<IPattern>()
            );
        }
    }
}
