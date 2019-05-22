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
    public class P0190_ReverseBitsTests
    {
        [Test()]
        public void reverseBitsTest()
        {
            uint input = 43261596;

            var reverseBits = new P0190_ReverseBits().reverseBits(input);

            Assert.AreEqual(964176192, reverseBits);
        }

        [Test()]
        public void reverseBitsTest_2()
        {
            uint input = 4294967293;

            var reverseBits = new P0190_ReverseBits().reverseBits(input);

            Assert.AreEqual(3221225471, reverseBits);
        }
    }
}