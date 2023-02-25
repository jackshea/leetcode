using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P1631_PathWithMinimumEffortTests
{
    [Test]
    public void MinimumEffortPathTest()
    {
        var test = new P1631_PathWithMinimumEffort();
        var input = Utils.Read2DArray("[[1,2,2],[3,8,2],[5,3,5]]");
        Assert.AreEqual(2, test.MinimumEffortPath(input));
    }
}