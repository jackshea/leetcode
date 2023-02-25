using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0655_PrintBinaryTreeTests
{
    [Test]
    public void PrintTreeTest()
    {
        var treeNode = Utils.BuildBinaryTree(new int?[] { 1, 2 });
        var test = new P0655_PrintBinaryTree();
        var printTree = test.PrintTree(treeNode);
        Assert.AreEqual("[[,1,],[2,,]]", Utils.Write2DArray(printTree));
    }
}