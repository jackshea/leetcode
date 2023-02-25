using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0673_NumberOfLongestIncreasingSubsequenceTests
{
    [Test]
    public void FindNumberOfLISTest()
    {
        var test = new P0673_NumberOfLongestIncreasingSubsequence();
        Assert.AreEqual(2, test.FindNumberOfLIS(new[] { 1, 3, 5, 4, 7 }));
    }
}