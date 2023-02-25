using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0797_AllPathsFromSourceToTargetTests
{
    [Test]
    public void AllPathsSourceTargetTest()
    {
        var test = new P0797_AllPathsFromSourceToTarget();
        var g = Utils.Read2DArray(" [[1,2],[3],[3],[]]");
        var expect = Utils.Read2DArray("[[0,1,3],[0,2,3]]");
        var ans = test.AllPathsSourceTarget(g);
        CollectionAssert.AreEquivalent(expect, ans);
    }
}