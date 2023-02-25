using System;

namespace LeetCode.Problems.Medium;

/// 面试题51. 数组中的逆序对
/// https://leetcode-cn.com/problems/shu-zu-zhong-de-ni-xu-dui-lcof/
public class MST51
{
    public int ReversePairs(int[] nums)
    {
        return MergeSort(nums, 0, nums.Length - 1);
    }

    public int MergeSort(int[] nums, int lo, int hi)
    {
        if (lo >= hi) return 0;

        var mid = lo + (hi - lo) / 2;
        var revCount = MergeSort(nums, lo, mid) + MergeSort(nums, mid + 1, hi);
        var i = lo;
        var j = mid + 1;
        var k = 0;
        var temp = new int[hi - lo + 1];
        while (i <= mid && j <= hi)
        {
            revCount += nums[i] <= nums[j] ? j - mid - 1 : 0;
            temp[k++] = nums[i] <= nums[j] ? nums[i++] : nums[j++];
        }

        while (i <= mid)
        {
            revCount += j - mid - 1;
            temp[k++] = nums[i++];
        }

        while (j <= hi) temp[k++] = nums[j++];
        Array.Copy(temp, 0, nums, lo, temp.Length);
        return revCount;
    }
}