using System;

namespace LeetCode.Problems
{
    /// 到达终点数字
    /// https://leetcode-cn.com/problems/reach-a-number/
    public class P0754_ReachANumber
    {
        public int ReachNumber(int target)
        {
            target = Math.Abs(target);
            int i = 0;
            while (target >= 0)
            {
                target -= ++i;
            }

            return target % 2 == 0 ? i : i + 1 + i % 2;
        }
    }
}