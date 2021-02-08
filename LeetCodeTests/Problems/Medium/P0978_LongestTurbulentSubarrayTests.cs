using NUnit.Framework;
using LeetCode.Problems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Medium.Tests
{
    [TestFixture()]
    public class P0978_LongestTurbulentSubarrayTests
    {
        [Test()]
        public void MaxTurbulenceSizeTest()
        {
            var test = new P0978_LongestTurbulentSubarray();
            Assert.AreEqual(5, test.MaxTurbulenceSize(new[] { 2, 1, 2, 1, 2 }));
        }

        [Test()]
        public void MaxTurbulenceSizeTest2()
        {
            var test = new P0978_LongestTurbulentSubarray();
            Assert.AreEqual(5, test.MaxTurbulenceSize(new[] { 1, 2, 1, 2, 1 }));
        }

        [Test()]
        public void MaxTurbulenceSizeTest3()
        {
            var test = new P0978_LongestTurbulentSubarray();
            Assert.AreEqual(5, test.MaxTurbulenceSize(new[] { 9, 4, 2, 10, 7, 8, 8, 1, 9 }));
        }

        [Test()]
        public void MaxTurbulenceSizeTest4()
        {
            var test = new P0978_LongestTurbulentSubarray();
            Assert.AreEqual(2, test.MaxTurbulenceSize(new[] { 4, 8, 12, 16 }));
        }

        [Test()]
        public void MaxTurbulenceSizeTest5()
        {
            var test = new P0978_LongestTurbulentSubarray();
            Assert.AreEqual(1, test.MaxTurbulenceSize(new[] { 100 }));
        }
    }
}