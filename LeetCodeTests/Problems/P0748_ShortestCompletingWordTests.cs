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
    public class P0748_ShortestCompletingWordTests
    {
        [Test()]
        public void ShortestCompletingWordTest()
        {
            var test = new P0748_ShortestCompletingWord();
            string result = test.ShortestCompletingWord("GrC8950",
                new String[]
                    {"measure", "other", "every", "base", "according", "level", "meeting", "none", "marriage", "rest"});

            Assert.AreEqual("according", result);
        }
    }
}