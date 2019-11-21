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
    public class P0819_MostCommonWordTests
    {
        [Test()]
        public void MostCommonWordTest()
        {
            var test = new P0819_MostCommonWord();
            var actual = test.MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new[] { "hit" });
            Assert.AreEqual("ball", actual);
        }
    }
}