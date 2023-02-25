using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0865_SmallestSubtreeWithAllTheDeepestNodesTests
{
    [Test]
    public void SubtreeWithAllDeepestTest()
    {
        var test = new P0865_SmallestSubtreeWithAllTheDeepestNodes();
        var input = Utils.BuildBinaryTree(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });
        var subtree = test.SubtreeWithAllDeepest(input);
        CollectionAssert.AreEquivalent(new[] { 2, 7, 4 }, Utils.Traversal(subtree));
    }
}