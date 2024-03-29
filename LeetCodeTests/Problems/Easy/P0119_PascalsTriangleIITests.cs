﻿using System.Collections.Generic;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0119_PascalsTriangleIITests
{
    [Test]
    public void GetRowTest()
    {
        var expect = new List<int> { 1, 4, 6, 4, 1 };

        var actual = new P0119_PascalsTriangleII().GetRow(4);

        Assert.AreEqual(expect, actual);
    }

    [Test]
    public void GetRowTest_1()
    {
        var expect = new List<int>
        {
            1, 30, 435, 4060, 27405, 142506, 593775, 2035800, 5852925, 14307150, 30045015, 54627300, 86493225,
            119759850, 145422675, 155117520, 145422675, 119759850, 86493225, 54627300, 30045015, 14307150, 5852925,
            2035800, 593775, 142506, 27405, 4060, 435, 30, 1
        };

        var actual = new P0119_PascalsTriangleII().GetRow(30);

        Assert.AreEqual(expect, actual);
    }
}