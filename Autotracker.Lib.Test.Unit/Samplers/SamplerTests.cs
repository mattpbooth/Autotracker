using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autotracker.Lib;
using System.Collections.Generic;
using Autotracker.Lib.Interfaces;

namespace Autotracker.Lib.Test.Unit
{
    [TestClass]
    public class SamplerTests
    {
        SamplerFactory _samplerFactory;

        [TestInitialize]
        public void Setup()
        {
            _samplerFactory = new SamplerFactory();
        }

        [TestMethod]
        public void FactoryInstancingSuccess()
        {
            var guitar = _samplerFactory.GetByKey(SamplerType.Guitar);
            var guitar2 = _samplerFactory.GetByKey(SamplerType.Guitar);

            Assert.IsFalse(guitar == guitar2);
            Assert.IsFalse(guitar.Equals(guitar2));
            Assert.IsFalse(ReferenceEquals(guitar,guitar2));
        }

        [TestMethod]
        public void GuitarSamplerGenerateSuccess()
        {
            var guitar = _samplerFactory.GetByKey(SamplerType.Guitar);
            Assert.IsTrue(guitar.Generate());
        }

        [TestMethod]
        public void BassSamplerGenerateSuccess()
        {
            var bass = _samplerFactory.GetByKey(SamplerType.Bass);
            Assert.IsTrue(bass.Generate());
        }

        [TestMethod]
        public void KickSamplerGenerateSuccess()
        {
            var kick = _samplerFactory.GetByKey(SamplerType.Kicker);
            Assert.IsTrue(kick.Generate());
        }

        [TestMethod]
        public void HiHatClosedSamplerGenerateSuccess()
        {
            var hiHat = _samplerFactory.GetByKey(SamplerType.HiHatClosed);
            Assert.IsTrue(hiHat.Generate());
        }

        [TestMethod]
        public void HiHatOpenSamplerGenerateSuccess()
        {
            var hiHat = _samplerFactory.GetByKey(SamplerType.HiHatOpen);
            Assert.IsTrue(hiHat.Generate());
        }

        public void SnareSamplerGenerateSuccess()
        {
            var snare = _samplerFactory.GetByKey(SamplerType.Snare);
            Assert.IsTrue(snare.Generate());
        }

    }
}
