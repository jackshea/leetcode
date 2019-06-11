using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Tests
{
    [TestClass()]
    public class P0405_ConvertANumberToHexadecimalTests
    {
        [TestMethod()]
        public void ToHexTest()
        {
            Assert.AreEqual("1a", new P0405_ConvertANumberToHexadecimal().ToHex(26));
        }

        [TestMethod()]
        public void ToHexTest_1()
        {
            Assert.AreEqual("0", new P0405_ConvertANumberToHexadecimal().ToHex(0));
        }

        [TestMethod()]
        public void ToHexTest_2()
        {
            Assert.AreEqual("ffffffff", new P0405_ConvertANumberToHexadecimal().ToHex(-1));
        }
    }
}