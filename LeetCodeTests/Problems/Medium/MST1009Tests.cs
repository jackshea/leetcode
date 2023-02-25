using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class MST1009Tests
{
    [Test]
    public void SearchMatrixTest()
    {
        int[,] input =
        {
            { 1, 4, 7, 11, 15 },
            { 2, 5, 8, 12, 19 },
            { 3, 6, 9, 16, 22 },
            { 10, 13, 14, 17, 24 },
            { 18, 21, 23, 26, 30 }
        };
        var test = new MST1009();
        Assert.IsTrue(test.SearchMatrix(input, 5));
        Assert.IsFalse(test.SearchMatrix(input, 20));
    }
}