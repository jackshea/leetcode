using System;

namespace LeetCode.Problems.Medium
{
    /// 最大交换
    /// https://leetcode-cn.com/problems/maximum-swap/
    public class P0670_MaximumSwap
    {
        public int MaximumSwap(int num)
        {
            var numChars = num.ToString().ToCharArray();
            var sortedChars = num.ToString().ToCharArray();
            Array.Sort(sortedChars, (a, b) => -a.CompareTo(b));
            int i = 0;
            for (; i < numChars.Length; i++)
            {
                if (numChars[i] != sortedChars[i])
                {
                    break;
                }
            }

            if (i == numChars.Length)
            {
                return num;
            }

            int j = numChars.Length - 1;
            while (j > i)
            {
                if (numChars[j] == sortedChars[i])
                {
                    break;
                }

                j--;
            }

            char temp = numChars[i];
            numChars[i] = numChars[j];
            numChars[j] = temp;
            return int.Parse(new string(numChars));
        }
    }
}