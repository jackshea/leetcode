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
    public class P0394_DecodeStringTests
    {
        [Test()]
        public void DecodeStringTest()
        {
            var test = new P0394_DecodeString();
            Assert.AreEqual("aaabcbc", test.DecodeString("3[a]2[bc]"));
            Assert.AreEqual("accaccacc", test.DecodeString("3[a2[c]]"));
            Assert.AreEqual("abcabccdcdcdef", test.DecodeString("2[abc]3[cd]ef"));
        }
    }
}