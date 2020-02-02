namespace LeetCode.Problems.Easy
{
    /// 搜索插入位置
    /// https://leetcode-cn.com/problems/search-insert-position/description/
    public class P0035_SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            return BinarySearch(nums, target, 0, nums.Length);
        }

        private int BinarySearch(int[] nums, int target, int leftIndex, int rightIndex)
        {
            if (rightIndex - leftIndex <= 1)
            {
                if (target <= nums[leftIndex])
                {
                    return leftIndex;
                }
                else
                {
                    return rightIndex;
                }
            }

            int mid = (leftIndex + rightIndex) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] > target)
            {
                rightIndex = mid;
            }
            else
            {
                leftIndex = mid;
            }

            return BinarySearch(nums, target, leftIndex, rightIndex);
        }
    }
}