using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0092_ReverseLinkedListIITests
{
    [Test]
    public void ReverseBetweenTest()
    {
        var list = Utils.BuildList(new[] { 1, 2, 3, 4, 5 });
        var test = new P0092_ReverseLinkedListII();
        var actual = test.ReverseBetween(list, 2, 4);
        Assert.AreEqual(new[] { 1, 4, 3, 2, 5 }, Utils.ListToArray(actual));
    }
}