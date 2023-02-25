using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0756_PyramidTransitionMatrixTests
{
    [Test]
    public void PyramidTransitionTest()
    {
        Assert.IsTrue(new P0756_PyramidTransitionMatrix()
            .PyramidTransition("BCD", new List<string>
            {
                "ACC", "ACB", "ABD", "DAA", "BDC", "BDB", "DBC", "BBD", "BBC", "DBD", "BCC", "CDD", "ABA", "BAB", "DDC",
                "CCD", "DDA", "CCA", "DDD"
            }));
    }
}