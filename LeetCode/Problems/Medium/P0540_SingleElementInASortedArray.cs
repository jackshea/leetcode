namespace LeetCode.Problems.Medium;

/// 有序数组中的单一元素
/// https://leetcode-cn.com/problems/single-element-in-a-sorted-array/
public class P0540_SingleElementInASortedArray
{
    public int SingleNonDuplicate(int[] nums)
    {
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (mid % 2 != 0) mid--;

            if (nums[mid] == nums[mid + 1])
                left = mid + 2;
            else
                right = mid;
        }

        return nums[left];
    }
}