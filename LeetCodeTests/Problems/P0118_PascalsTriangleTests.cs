﻿using NUnit.Framework;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Tests
{
    [TestFixture()]
    public class P0118_PascalsTriangleTests
    {
        [Test()]
        public void GenerateTest()
        {
            var expect = new List<List<int>>
            {
                new List<int>{1},
                new List<int>{1, 1},
                new List<int>{1, 2, 1},
                new List<int>{1, 3, 3, 1},
                new List<int>{1, 4, 6, 4, 1}
            };

            var actual = new P0118_PascalsTriangle().Generate(5);

            Assert.AreEqual(expect, actual);
        }
    }
}