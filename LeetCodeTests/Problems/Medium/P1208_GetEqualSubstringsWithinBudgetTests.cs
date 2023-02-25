using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P1208_GetEqualSubstringsWithinBudgetTests
{
    [Test]
    public void EqualSubstringTest()
    {
        var test = new P1208_GetEqualSubstringsWithinBudget();
        Assert.AreEqual(3, test.EqualSubstring("abcd", "bcdf", 3));
    }
}