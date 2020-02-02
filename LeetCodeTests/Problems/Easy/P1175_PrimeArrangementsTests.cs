using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
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