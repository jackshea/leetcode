﻿using LeetCode.Problems.Hard;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0224_BasicCalculatorTests
{
    [Test]
    public void CalculateTest()
    {
        var test = new P0224_BasicCalculator();
        var actual = test.Calculate("(1+(4+5+2)-3)+(6+8)");
        Assert.AreEqual(23, actual);
    }
}