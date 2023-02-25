using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0748_ShortestCompletingWordTests
{
    [Test]
    public void ShortestCompletingWordTest()
    {
        var test = new P0748_ShortestCompletingWord();
        var result = test.ShortestCompletingWord("GrC8950",
            new[]
                { "measure", "other", "every", "base", "according", "level", "meeting", "none", "marriage", "rest" });

        Assert.AreEqual("according", result);
    }
}