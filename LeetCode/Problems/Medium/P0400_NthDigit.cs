using System;

namespace LeetCode.Problems.Medium
{
    /// 第N个数字
    /// https://leetcode-cn.com/problems/nth-digit/
    public class P0400_NthDigit
    {
        public int FindNthDigit(int n)
        {
            if (n <= 9)
            {
                return n;
            }

            long curN = n;
            int digitLevel = 1;
            long baseNum = 9;
            while (curN > digitLevel * baseNum)
            {
                curN -= digitLevel * baseNum;
                digitLevel++;
                baseNum *= 10;
            }

            var num = (curN - 1) / digitLevel + Math.Pow(10, digitLevel - 1);
            var numString = num.ToString();
            var mod = (int)curN % digitLevel;
            return (mod == 0 ? numString[digitLevel - 1] : numString[mod - 1]) - '0';
        }
    }
}