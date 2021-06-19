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
    public class P1239_MaximumLengthOfAConcatenatedStringWithUniqueCharactersTests
    {
        [Test()]
        public void MaxLengthTest()
        {
            var test = new P1239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters();
            var input = new List<string>() { "un", "iq", "ue" };
            Assert.AreEqual(4, test.MaxLength(input));
        }
    }
}