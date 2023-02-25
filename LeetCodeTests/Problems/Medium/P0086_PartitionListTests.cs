using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0086_PartitionListTests
{
    [Test]
    public void PartitionTest()
    {
        var list = Utils.BuildList(new[] { 1, 4, 3, 2, 5, 2 });
        var test = new P0086_PartitionList();
        var actual = test.Partition(list, 3);
        Assert.AreEqual(new[] { 1, 2, 2, 4, 3, 5 }, Utils.ListToArray(actual));
    }

    [Test]
    public void PartitionTest1()
    {
        var list = Utils.BuildList(new[] { 3, 1, 2 });
        var test = new P0086_PartitionList();
        var actual = test.Partition(list, 3);
        Assert.AreEqual(new[] { 1, 2, 3 }, Utils.ListToArray(actual));
    }
}