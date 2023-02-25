using LeetCode.Common;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0437_PathSumIIITests
{
    [Test]
    public void PathSumTest()
    {
        var inputNodes = new int?[] { 1, -2, -3, 1, 3, -2, null, -1 };
        var inputSum = -1;

        var bTree = Utils.BuildBinaryTree(inputNodes);
        var expected = 4;

        Assert.AreEqual(expected, new P0437_PathSumIII().PathSum(bTree, inputSum));
    }

    [Test]
    public void PathSumTest_1()
    {
        var inputNodes = new int?[] { -1 };
        var inputSum = -1;

        var bTree = Utils.BuildBinaryTree(inputNodes);
        var expected = 1;

        Assert.AreEqual(expected, new P0437_PathSumIII().PathSum(bTree, inputSum));
    }

    [Test]
    public void PathSumTest_2()
    {
        var inputNodes = new int?[] { 1, -2, -3 };
        var inputSum = -1;

        var bTree = Utils.BuildBinaryTree(inputNodes);
        var expected = 1;

        Assert.AreEqual(expected, new P0437_PathSumIII().PathSum(bTree, inputSum));
    }

    [Test]
    public void PathSumTest_3()
    {
        var inputNodes = new int?[] { -2, 1, 3 };
        var inputSum = -1;

        var bTree = Utils.BuildBinaryTree(inputNodes);
        var expected = 1;

        Assert.AreEqual(expected, new P0437_PathSumIII().PathSum(bTree, inputSum));
    }

    [Test]
    public void PathSumTest_4()
    {
        var inputNodes = new int?[]
        {
            0, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0,
            null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null,
            0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0, null, 0
        };
        var inputSum = 0;

        var bTree = Utils.BuildBinaryTree(inputNodes);
        var expected = 66;

        Assert.AreEqual(expected, new P0437_PathSumIII().PathSum(bTree, inputSum));
    }
}