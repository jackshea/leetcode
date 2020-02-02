using System.Collections.Generic;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0367_ValidPerfectSquareTests
    {
        [Test()]
        public void IsPerfectSquareTest()
        {
            var test = new P0367_ValidPerfectSquare();
            HashSet<int> sq = new HashSet<int>();
            Assert.IsTrue(test.IsPerfectSquare(93025));
            for (int i = 1; i <= 1000; i++)
            {
                var sqr = i * i;
                sq.Add(sqr);
                Assert.IsTrue(test.IsPerfectSquare(sqr), sqr.ToString());
            }

            for (int i = 1; i <= 1000000; i++)
            {
                Assert.AreEqual(sq.Contains(i), test.IsPerfectSquare(i));
            }
        }
    }
}