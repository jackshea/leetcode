using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0143_ReorderListTests
{
    [Test]
    public void ReorderListTest()
    {
        var node = Utils.BuildList(new[] { 1, 2, 3, 4 });
        var test = new P0143_ReorderList();
        test.ReorderList(node);
        Assert.AreEqual(new[] { 1, 4, 2, 3 }, Utils.ListToArray(node));
    }
}