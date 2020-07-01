using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 根据数字二进制下 1 的数目排序
    /// https://leetcode-cn.com/problems/sort-integers-by-the-number-of-1-bits/
    public class P1356_SortIntegersByTheNumberOf1Bits
    {
        public int[] SortByBits(int[] arr)
        {
            Dictionary<int, int> hw = new Dictionary<int, int>();
            foreach (var n in arr)
            {
                hw[n] = HammingWeight(n);
            }

            Array.Sort(arr, (a, b) =>
            {
                var ahw = hw[a];
                var bhw = hw[b];
                if (ahw == bhw)
                {
                    return a.CompareTo(b);
                }

                return ahw.CompareTo(bhw);
            });
            return arr;
        }

        private int HammingWeight(int n)
        {
            int count = 0;
            while (n != 0)
            {
                if (n % 2 == 1)
                {
                    count++;
                }

                n = n >> 1;
            }

            return count;
        }
    }
}