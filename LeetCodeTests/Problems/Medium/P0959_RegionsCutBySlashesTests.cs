using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0959_RegionsCutBySlashesTests
{
    [Test]
    public void RegionsBySlashesTest()
    {
        var input = new[] { " /", "/ " };
        var test = new P0959_RegionsCutBySlashes();
        Assert.AreEqual(2, test.RegionsBySlashes(input));
    }
}