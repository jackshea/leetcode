using NUnit.Framework;
using LeetCode.Problems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode.Problems.Medium.Tests
{
    [TestFixture()]
    public class P0909_SnakesAndLaddersTests
    {
        [Test()]
        public void SnakesAndLaddersTest()
        {
            var test = new P0909_SnakesAndLadders();
            var input = Utils.Read2DArray(
                "[[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,35,-1,-1,13,-1],[-1,-1,-1,-1,-1,-1],[-1,15,-1,-1,-1,-1]]");
            Assert.AreEqual(4,test.SnakesAndLadders(input));
        }
    }
}