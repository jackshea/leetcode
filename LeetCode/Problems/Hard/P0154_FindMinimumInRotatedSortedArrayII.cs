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
                while (left < right && nums[left] == nums[left + 1])
                {
                    left++;
                }

                while (left < right && nums[right] == nums[right - 1])
                {
                    right--;
                }

                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return nums[left];
        }
    }
}