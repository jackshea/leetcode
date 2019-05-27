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
    public class P0349_IntersectionOfTwoArraysTests
    {
        [Test()]
        public void IntersectionTest()
        {
            var num1 = new int[] { 1, 2, 2, 1 };
            var num2 = new int[] { 2, 2 };

            var intersection = new P0349_IntersectionOfTwoArrays().Intersection(num1, num2);
            var expect = new int[] { 2 };

            Assert.AreEqual(expect, intersection);
        }
    }
}