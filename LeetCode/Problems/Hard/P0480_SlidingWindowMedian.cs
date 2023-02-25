using System;

namespace LeetCode.Problems.Hard;

/// 滑动窗口中位数
/// https://leetcode-cn.com/problems/sliding-window-median/
public class P0480_SlidingWindowMedian
{
    public double[] MedianSlidingWindow(int[] nums, int k)
    {
        var ans = new double[nums.Length - k + 1];
        var window = new int[k];
        for (var i = 0; i < k; i++) window[i] = nums[i];

        Array.Sort(window);
        for (var i = 0; i < ans.Length - 1; i++)
        {
            ans[i] = Median(window);
            ReplaceAndSort(window, nums[i], nums[i + k]);
        }

        ans[ans.Length - 1] = Median(window);
        return ans;
    }

    private double Median(int[] nums)
    {
        var halfLen = nums.Length / 2;
        if (nums.Length % 2 == 0) return nums[halfLen - 1] / 2.0 + nums[halfLen] / 2.0;

        return nums[halfLen];
    }

    private void ReplaceAndSort(int[] nums, int oldVal, int newVal)
    {
        if (oldVal == newVal) return;

        var idx = Array.BinarySearch(nums, oldVal);
        if (oldVal < newVal)
            while (idx < nums.Length - 1 && nums[idx + 1] < newVal)
            {
                nums[idx] = nums[idx + 1];
                idx++;
            }
        else
            while (idx > 0 && nums[idx - 1] > newVal)
            {
                nums[idx] = nums[idx - 1];
                idx--;
            }

        nums[idx] = newVal;
    }
}