using System;

namespace LeetCode.Problems.Easy
{
    /// 给定数字能组成的最大时间
    /// https://leetcode-cn.com/problems/largest-time-for-given-digits/
    public class P0949_LargestTimeForGivenDigits
    {
        public string LargestTimeFromDigits(int[] A)
        {
            Array.Sort(A, (a, b) => -a.CompareTo(b));
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    for (int k = 0; k < 4; k++)
                    {
                        if (i == k || j == k)
                        {
                            continue;
                        }

                        int l = 6 - i - j - k;
                        if (A[i] * 10 + A[j] < 24 && A[k] * 10 + A[l] < 60)
                        {
                            return "" + A[i] + A[j] + ":" + A[k] + A[l];
                        }
                    }
                }
            }

            return string.Empty;
        }
    }
}