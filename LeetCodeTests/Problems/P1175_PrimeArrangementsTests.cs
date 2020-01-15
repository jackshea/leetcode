using NUnit.Framework;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Tests
{
    [TestFixture()]
    public class P1175_PrimeArrangementsTests
    {
        [Test()]
        public void NumPrimeArrangementsTest()
        {
            var test = new P1175_PrimeArrangements();
            Assert.AreEqual(612735986, test.NumPrimeArrangements(16));
        }
    }
}