using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0819_MostCommonWordTests
{
    [Test]
    public void MostCommonWordTest()
    {
        var test = new P0819_MostCommonWord();
        var actual = test.MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new[] { "hit" });
        Assert.AreEqual("ball", actual);
    }
}