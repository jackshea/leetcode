namespace LeetCode.Problems.Medium
{
    /// 搜索旋转排序数组
    /// https://leetcode-cn.com/problems/search-in-rotated-sorted-array/
    public class P0033_SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }

                if ((nums[0] > target) ^ (nums[0] > nums[mid]) ^ (target > nums[mid]))
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}