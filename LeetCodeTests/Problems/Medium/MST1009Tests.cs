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
    public class MST1009Tests
    {
        [Test()]
        public void SearchMatrixTest()
        {
            int[][] input = new int[][] {
                new []{1, 4, 7, 11, 15},
                new []{2, 5, 8, 12, 19},
                new []{3, 6, 9, 16, 22},
                new []{10, 13, 14, 17, 24},
                new []{18, 21, 23, 26, 30}};
            var test = new MST1009();
            Assert.IsTrue(test.SearchMatrix(input, 5));
            Assert.IsFalse(test.SearchMatrix(input, 20));
        }
    }
}