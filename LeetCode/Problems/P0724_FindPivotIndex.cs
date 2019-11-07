using System.Linq;

namespace LeetCode.Problems
{
    /// 寻找数组的中心索引
    /// https://leetcode-cn.com/problems/find-pivot-index/
    public class P0724_FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            var sum = nums.Sum();
            var leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i])
                {
                    return i;
                }

                leftSum += nums[i];
            }

            return -1;
        }
    }
}