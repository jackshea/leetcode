using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0322_CoinChangeTests
{
    [Test]
    public void CoinChangeTest()
    {
        var test = new P0322_CoinChange();
        var count = test.CoinChange(new[] { 1, 2, 5 }, 11);
        Assert.AreEqual(3, count);
    }
}