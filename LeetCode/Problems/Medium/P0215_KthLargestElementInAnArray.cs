using System;

namespace LeetCode.Problems.Medium;

/// 数组中的第K个最大元素
/// https://leetcode-cn.com/problems/kth-largest-element-in-an-array/
public class P0215_KthLargestElementInAnArray
{
    private Random rand;

    public int FindKthLargest(int[] nums, int k)
    {
        k--;
        if (nums.Length == 1) return nums[k];
        rand = new Random((int)DateTime.Now.Ticks);
        var start = 0;
        var end = nums.Length - 1;
        while (start < end)
        {
            var p = Partition(nums, start, end);
            if (p > k)
                end = p - 1;
            else if (p < k)
                start = p + 1;
            else
                return nums[p];
        }

        return nums[start];
    }

    public int Partition(int[] nums, int start, int end)
    {
        var p = rand.Next(start, end + 1);
        var pn = nums[p];
        nums[p] = nums[start];

        while (start < end)
        {
            while (nums[end] <= pn && start < end) end--;

            nums[start] = nums[end];
            while (nums[start] >= pn && start < end) start++;

            nums[end] = nums[start];
        }

        nums[start] = pn;
        return start;
    }
}