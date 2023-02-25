using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0088_MergeSortedArrayTests
{
    [Test]
    public void MergeTest_1()
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        var m = 3;
        int[] nums2 = { 2, 5, 6 };
        var n = 3;

        var test = new P0088_MergeSortedArray();
        test.Merge(nums1, m, nums2, n);

        Assert.AreEqual(new[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }

    [Test]
    public void MergeTest_2()
    {
        int[] nums1 = { 0 };
        var m = 0;
        int[] nums2 = { 1 };
        var n = 1;

        var test = new P0088_MergeSortedArray();
        test.Merge(nums1, m, nums2, n);

        Assert.AreEqual(new[] { 1 }, nums1);
    }
}