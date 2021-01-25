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
    public class P0959_RegionsCutBySlashesTests
    {
        [Test()]
        public void RegionsBySlashesTest()
        {
            var input = new[] { " /", "/ " };
            var test = new P0959_RegionsCutBySlashes();
            Assert.AreEqual(2, test.RegionsBySlashes(input));
        }
    }
}