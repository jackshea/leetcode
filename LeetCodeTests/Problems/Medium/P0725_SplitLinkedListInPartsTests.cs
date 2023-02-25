using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0725_SplitLinkedListInPartsTests
{
    [Test]
    public void SplitListToPartsTest()
    {
        var test = new P0725_SplitLinkedListInParts();
        var ans = test.SplitListToParts(Utils.BuildList(new[] { 1, 2, 3 }), 5);
        var actual = new int[5][];
        for (var i = 0; i < actual.Length; i++) actual[i] = Utils.ListToArray(ans[i]);

        int[][] except =
        {
            new[] { 1 },
            new[] { 2 },
            new[] { 3 },
            new int[0],
            new int[0]
        };

        CollectionAssert.AreEqual(except, actual);
    }
}