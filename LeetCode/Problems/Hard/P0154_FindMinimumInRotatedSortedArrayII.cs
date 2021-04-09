namespace LeetCode.Problems.Hard
{
    /// 寻找旋转排序数组中的最小值 II
    /// https://leetcode-cn.com/problems/find-minimum-in-rotated-sorted-array-ii/
    public class P0154_FindMinimumInRotatedSortedArrayII
    {
        public int FindMin(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else if (nums[mid] < nums[right])
                {
                    right = mid;
                }
                else
                {
                    right--;
                }
            }

            return nums[left];
        }
    }
}