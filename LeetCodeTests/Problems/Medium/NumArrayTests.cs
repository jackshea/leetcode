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
    public class NumArrayTests
    {
        [Test()]
        public void NumArrayTest()
        {
            var test = new NumArray(new[] { 1, 3, 5 });
            Assert.AreEqual(9, test.SumRange(0, 2));
            test.Update(1, 2);
            Assert.AreEqual(8, test.SumRange(0, 2));
        }

        [Test()]
        public void NumArrayTest_1()
        {
            var test = new NumArray(new[] { -1 });
            Assert.AreEqual(-1, test.SumRange(0, 0));
            test.Update(0, 1);
            Assert.AreEqual(1, test.SumRange(0, 0));
        }

        [Test()]
        public void NumArrayTest_2()
        {
            var test = new NumArray(new[] { 9, -8 });
            test.Update(0, 3);
            Assert.AreEqual(-8, test.SumRange(1, 1));
            Assert.AreEqual(-5, test.SumRange(0, 1));
            test.Update(1, -3);
            Assert.AreEqual(0, test.SumRange(0, 1));
        }

        [Test()]
        public void NumArrayTest_3()
        {
            var test = new NumArray(new[] { -28, -39, 53, 65, 11, -56, -65, -39, -43, 97 });
            Assert.AreEqual(-56 - 65, test.SumRange(5, 6));
            test.Update(9, 27);
            Assert.AreEqual(118, test.SumRange(2, 3));
            Assert.AreEqual(-104, test.SumRange(6, 7));
            test.Update(1, -82);
            test.Update(3, -72);
            Assert.AreEqual(-221, test.SumRange(3, 7));
            Assert.AreEqual(-293, test.SumRange(1, 8));
            test.Update(5, 13);
            test.Update(4, -67);
        }
    }
}