using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0082_RemoveDuplicatesFromSortedListIITests
{
    [Test]
    public void DeleteDuplicatesTest()
    {
        var list = Utils.BuildList(new[] { 1, 2, 3, 3, 4, 4, 5 });
        Assert.AreEqual(new[] { 1, 2, 3, 3, 4, 4, 5 }, Utils.ListToArray(list));
    }

    [Test]
    public void DeleteDuplicatesTest_1()
    {
        var test = new P0082_RemoveDuplicatesFromSortedListII();
        var list = Utils.BuildList(new[] { 1, 2, 3, 3, 4, 4, 5 });
        var actual = test.DeleteDuplicates(list);
        Assert.AreEqual(new[] { 1, 2, 5 }, Utils.ListToArray(actual));
    }
}