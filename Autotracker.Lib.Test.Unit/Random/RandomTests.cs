using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotracker.Lib.Test.Unit
{
    [TestClass]
    public class RandomTests
    {
        RandomInt _randomInt;
        RandomDouble _randomDouble;

        [TestInitialize]
        public void Setup()
        {
            _randomInt = new RandomInt();
            _randomDouble = new RandomDouble();
        }

        [TestMethod]
        public void GetNextIntReturns0ToMaxInt32Success()
        {
            var intNext = _randomInt.GetNext();
            Assert.IsTrue(intNext >= 0 && intNext <= Int32.MaxValue);
        }

        [TestMethod]
        public void GetNextIntRangedReturnsRangeSuccess()
        {
            var intNext = _randomInt.GetNextRange(-200, 1000);
            Assert.IsTrue(intNext >= -200 && intNext <= 1000);
        }

        [TestMethod]
        public void GetChoiceIntReturnsValidChoiceSuccess()
        {
            int[] population = {1,2,3,4,5};
            var choices = new List<int>(population);

            var intNext = _randomInt.Choice(choices);
            Assert.IsTrue(intNext >= 1 && intNext <= 5);
        }

        [TestMethod]
        public void GetNextDoubleReturns0To1Success()
        {
            var doubleNext = _randomDouble.GetNext();
            Assert.IsTrue(doubleNext >= 0.0 && doubleNext <= 1.0);
        }

        [TestMethod]
        public void GetNextDoubleRangedReturnsRangeSuccess()
        {
            var doubleNext = _randomDouble.GetNextRange(-200.0, 1000.0);
            Assert.IsTrue(doubleNext >= -200.0 && doubleNext <= 1000.0);
        }

        [TestMethod]
        public void GetChoiceDoubleReturnsValidChoiceSuccess()
        {
            double[] population = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            var choices = new List<double>(population);

            var doubleNext = _randomDouble.Choice(choices);
            Assert.IsTrue(doubleNext >= 1.0 && doubleNext <= 5.0);
        }
    }
}
