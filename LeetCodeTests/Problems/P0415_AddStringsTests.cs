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
    public class P0415_AddStringsTests
    {
        [Test()]
        public void AddStringsTest()
        {
            Assert.AreEqual("58023", new P0415_AddStrings().AddStrings("1234", "56789"));
        }

        [Test()]
        public void AddStringsTest_1()
        {
            Assert.AreEqual("108", new P0415_AddStrings().AddStrings("9", "99"));
        }
    }
}