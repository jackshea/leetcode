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
    public class P0067_AddBinaryTests
    {
        [Test()]
        public void AddBinaryTest_1()
        {
            string a = "11";
            string b = "1";
            var test = new P0067_AddBinary();

            var output = test.AddBinary(a, b);

            Assert.AreEqual("100", output);
        }

        [Test()]
        public void AddBinaryTest_2()
        {
            string a = "1010";
            string b = "1011";
            var test = new P0067_AddBinary();

            var output = test.AddBinary(a, b);

            Assert.AreEqual("10101", output);
        }
    }
}