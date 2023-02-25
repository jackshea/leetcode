namespace LeetCode.Problems.Medium;

/// 寻找峰值
/// https://leetcode-cn.com/problems/find-peak-element/
public class P0162_FindPeakElement
{
    public int FindPeakElement(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] < nums[mid + 1])
                left = mid + 1;
            else
                right = mid;
        }

        return left;
    }
}