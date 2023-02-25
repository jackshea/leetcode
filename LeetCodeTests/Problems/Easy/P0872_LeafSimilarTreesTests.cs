using LeetCode.Common;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0872_LeafSimilarTreesTests
{
    [Test]
    public void LeafSimilarTest()
    {
        var treeNode1 = Utils.BuildBinaryTree(new int?[] { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 });
        var treeNode2 = Utils.BuildBinaryTree(new int?[]
            { 3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8 });
        var test = new P0872_LeafSimilarTrees();
        var check = test.LeafSimilar(treeNode1, treeNode2);
        Assert.AreEqual(true, check);
    }
}