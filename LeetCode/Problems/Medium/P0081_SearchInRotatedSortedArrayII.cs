namespace LeetCode.Problems.Medium;

/// 搜索旋转排序数组 II
/// https://leetcode-cn.com/problems/search-in-rotated-sorted-array-ii/
public class P0081_SearchInRotatedSortedArrayII
{
    public bool Search(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            while (left < right && nums[left] == nums[left + 1]) left++;

            while (left < right && nums[right] == nums[right - 1]) right--;

            var mid = left + (right - left) / 2;
            if (nums[mid] == target) return true;
            if (nums[mid] >= nums[left])
            {
                if (target < nums[mid] && target >= nums[left])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            else
            {
                if (target > nums[mid] && target <= nums[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        return false;
    }
}