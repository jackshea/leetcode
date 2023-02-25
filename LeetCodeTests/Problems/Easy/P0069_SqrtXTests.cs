using System;
using System.Collections.Generic;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0069_SqrtXTests
{
    [Test]
    public void MySqrtTest()
    {
        var test = new P0069_SqrtX();

        test.MySqrt(4);

        var inputs = new List<int>();
        for (var i = 0; i < 100; i++) inputs.Add(i);

        var expects = new List<int>();
        for (var i = 0; i < 100; i++) expects.Add((int)Math.Sqrt(inputs[i]));

        var outputs = new List<int>();
        for (var i = 0; i < 100; i++) outputs.Add(test.MySqrt(inputs[i]));

        Assert.AreEqual(expects, outputs);
    }
}