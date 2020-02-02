using System.Linq;

namespace LeetCode.Problems.Easy
{
    /// 最小移动次数使数组元素相等
    /// https://leetcode-cn.com/problems/minimum-moves-to-equal-array-elements/
    /// n-1 个数+1 相当于某个数-1. 即问题转化为数组中的数都转为最小的数需要执行多少次-1的操作。
    /// 需要处理数组中的数大于整型最大值的值的情况
    public class P0453_MinimumMovesToEqualArrayElements
    {
        public int MinMoves(int[] nums)
        {
            int min = nums.Min();
            int result = 0;
            foreach (var num in nums)
            {
                result += num - min;
            }

            return result;
        }
    }
}