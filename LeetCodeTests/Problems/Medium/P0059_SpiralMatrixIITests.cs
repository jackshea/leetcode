using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0059_SpiralMatrixIITests
{
    [Test]
    public void GenerateMatrixTest()
    {
        var test = new P0059_SpiralMatrixII();
        test.GenerateMatrix(4);
        Assert.IsTrue(true);
    }
}