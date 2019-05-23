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
    public class P0219_ContainsDuplicateIITests
    {
        [Test()]
        public void ContainsNearbyDuplicateTest()
        {
            var input = new int[] { 1, 0, 1, 1 };
            var k = 1;

            Assert.IsTrue(new P0219_ContainsDuplicateII().ContainsNearbyDuplicate(input, k));
        }
    }
}