namespace LeetCode.Problems.Easy;

/// 二分查找
/// https://leetcode-cn.com/problems/binary-search/
public class P0704_BinarySearch
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target) return mid;

            if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}