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
    public class P0350_IntersectionOfTwoArraysIITests
    {
        [Test()]
        public void IntersectTest()
        {
            var num1 = new int[] { 1, 2, 2, 1 };
            var num2 = new int[] { 2, 2 };

            var intersection = new P0350_IntersectionOfTwoArraysII().Intersect(num1, num2);
            var expect = new int[] { 2, 2 };

            Assert.AreEqual(expect, intersection);
        }

        [Test()]
        public void IntersectTest_2()
        {
            var num1 = new int[] { 4, 9, 5 };
            var num2 = new int[] { 9, 4, 9, 8, 4 };

            var intersection = new P0350_IntersectionOfTwoArraysII().Intersect(num1, num2);
            var expect = new int[] { 4, 9 };

            Assert.AreEqual(expect, intersection);
        }
    }
}