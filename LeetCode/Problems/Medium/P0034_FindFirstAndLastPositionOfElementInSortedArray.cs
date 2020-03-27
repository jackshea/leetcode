namespace LeetCode.Problems.Medium
{
    /// 在排序数组中查找元素的第一个和最后一个位置
    /// https://leetcode-cn.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    public class P0034_FindFirstAndLastPositionOfElementInSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    int first = mid - 1, last = mid + 1;
                    while (first >= 0 && nums[first] == nums[mid])
                    {
                        first--;
                    }

                    while (last < nums.Length && nums[last] == nums[mid])
                    {
                        last++;
                    }

                    return new[] { first + 1, last - 1 };
                }
            }

            return new[] { -1, -1 };
        }
    }
}