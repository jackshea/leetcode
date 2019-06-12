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
    public class P0434_NumberOfSegmentsInAStringTests
    {
        [Test()]
        public void CountSegmentsTest()
        {
            var input = "Hello, my name is John";

            var expected = 5;

            Assert.AreEqual(expected, new P0434_NumberOfSegmentsInAString().CountSegments(input));
        }

        [Test()]
        public void CountSegmentsTest_1()
        {
            var input = "a";

            var expected = 1;

            Assert.AreEqual(expected, new P0434_NumberOfSegmentsInAString().CountSegments(input));
        }

        [Test()]
        public void CountSegmentsTest_2()
        {
            var input = "aa";

            var expected = 1;

            Assert.AreEqual(expected, new P0434_NumberOfSegmentsInAString().CountSegments(input));
        }

        [Test()]
        public void CountSegmentsTest_3()
        {
            var input = "aa b";

            var expected = 2;

            Assert.AreEqual(expected, new P0434_NumberOfSegmentsInAString().CountSegments(input));
        }

        [Test()]
        public void CountSegmentsTest_4()
        {
            var input = "a  b";

            var expected = 2;

            Assert.AreEqual(expected, new P0434_NumberOfSegmentsInAString().CountSegments(input));
        }

        [Test()]
        public void CountSegmentsTest_5()
        {
            var input = "a  b ";

            var expected = 2;

            Assert.AreEqual(expected, new P0434_NumberOfSegmentsInAString().CountSegments(input));
        }

        [Test()]
        public void CountSegmentsTest_6()
        {
            var input = "  a  b ";

            var expected = 2;

            Assert.AreEqual(expected, new P0434_NumberOfSegmentsInAString().CountSegments(input));
        }
    }
}