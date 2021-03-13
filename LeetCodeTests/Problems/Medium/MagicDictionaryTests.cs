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
    public class MagicDictionaryTests
    {
        [Test()]
        public void SearchTest()
        {
            var test = new MagicDictionary();
            test.BuildDict(new string[] { "hello", "leetcode" });
            Assert.IsFalse(test.Search("hello"));
            Assert.IsTrue(test.Search("hhllo"));
            Assert.IsFalse(test.Search("hell"));
            Assert.IsFalse(test.Search("leetcoded"));
        }

        [Test()]
        public void SearchTest1()
        {
            var test = new MagicDictionary();
            test.BuildDict(new string[] { "hello","hallo", "leetcode" });
            Assert.IsTrue(test.Search("hello"));
            Assert.IsTrue(test.Search("hhllo"));
            Assert.IsFalse(test.Search("hell"));
            Assert.IsFalse(test.Search("leetcoded"));
        }
    }
}