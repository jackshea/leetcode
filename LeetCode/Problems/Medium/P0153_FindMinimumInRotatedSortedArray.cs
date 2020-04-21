namespace LeetCode.Problems.Medium
{
    /// 寻找旋转排序数组中的最小值
    /// https://leetcode-cn.com/problems/find-minimum-in-rotated-sorted-array/
    public class P0153_FindMinimumInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < nums[right])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return nums[left];
        }
    }
}