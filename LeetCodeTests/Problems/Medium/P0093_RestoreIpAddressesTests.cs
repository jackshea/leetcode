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
    public class P0093_RestoreIpAddressesTests
    {
        [Test()]
        public void RestoreIpAddressesTest()
        {
            var test = new P0093_RestoreIpAddresses();
            var actual = test.RestoreIpAddresses("25525511135");
            var expected = new List<string> { "255.255.11.135", "255.255.111.35" };
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void RestoreIpAddressesTest1()
        {
            var test = new P0093_RestoreIpAddresses();
            var actual = test.RestoreIpAddresses("0000");
            var expected = new List<string> { "0.0.0.0" };
            Assert.AreEqual(expected, actual);
        }
    }
}