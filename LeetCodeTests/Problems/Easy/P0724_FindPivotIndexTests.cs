using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0724_FindPivotIndexTests
{
    [Test]
    public void PivotIndexTest_1()
    {
        var test = new P0724_FindPivotIndex();
        var pivotIndex = test.PivotIndex(new int[] { });
        Assert.AreEqual(-1, pivotIndex);
    }

    [Test]
    public void PivotIndexTest_2()
    {
        var test = new P0724_FindPivotIndex();
        var pivotIndex = test.PivotIndex(new[] { 1 });
        Assert.AreEqual(0, pivotIndex);
    }

    [Test]
    public void PivotIndexTest_3()
    {
        var test = new P0724_FindPivotIndex();
        var pivotIndex = test.PivotIndex(new[] { 1, 1 });
        Assert.AreEqual(-1, pivotIndex);
    }

    [Test]
    public void PivotIndexTest_4()
    {
        var test = new P0724_FindPivotIndex();
        var pivotIndex = test.PivotIndex(new[] { 1, 7, 3, 6, 5, 6 });
        Assert.AreEqual(3, pivotIndex);
    }

    [Test]
    public void PivotIndexTest_5()
    {
        var test = new P0724_FindPivotIndex();
        var pivotIndex = test.PivotIndex(new[] { 1, 0, 0, 1 });
        Assert.AreEqual(1, pivotIndex);
    }

    [Test]
    public void PivotIndexTest_6()
    {
        var test = new P0724_FindPivotIndex();
        var pivotIndex = test.PivotIndex(new[] { 1, 2, 0, 0, 0, 0, 2, 1 });
        Assert.AreEqual(2, pivotIndex);
    }
}