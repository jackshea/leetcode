using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Easy.Tests;

[TestFixture]
public class MST0207Tests
{
    [Test]
    public void GetIntersectionNodeTest()
    {
        var common = Utils.BuildList(new[] { 8, 4, 5 });
        var listA = Utils.BuildList(new[] { 4, 1 });
        var listB = Utils.BuildList(new[] { 5, 0, 1 });
        Utils.ConnectList(listA, common);
        Utils.ConnectList(listB, common);
        var test = new MST0207();
        var intersectionNode = test.GetIntersectionNode(listA, listB);
        Assert.AreEqual(intersectionNode, common);
    }
}