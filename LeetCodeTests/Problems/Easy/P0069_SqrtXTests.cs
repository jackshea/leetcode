using System;
using System.Collections.Generic;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0069_SqrtXTests
    {
        [Test()]
        public void MySqrtTest()
        {
            var test = new P0069_SqrtX();

            test.MySqrt(4);

            List<int> inputs = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                inputs.Add(i);
            }

            List<int> expects = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                expects.Add((int)Math.Sqrt(inputs[i]));
            }

            List<int> outputs = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                outputs.Add(test.MySqrt(inputs[i]));
            }

            Assert.AreEqual(expects, outputs);
        }
    }
}