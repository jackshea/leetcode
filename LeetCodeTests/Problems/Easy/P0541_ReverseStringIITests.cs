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
    public class P0541_ReverseStringIITests
    {
        [Test()]
        public void ReverseStrTest()
        {
            var test = new P0541_ReverseStringII();

            Assert.AreEqual("gfedcba", test.ReverseStr("abcdefg", 8));
        }
    }
}