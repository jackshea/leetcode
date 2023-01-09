using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 还原排列的最少操作步数
    /// https://leetcode.cn/problems/minimum-number-of-operations-to-reinitialize-a-permutation/
    public class P1806_MinimumNumberOfOperationsToReinitializeAPermutation
    {
        public int ReinitializePermutation(int n)
        {
            int[] raw = new int[n];
            int[] perm = new int[n];
            for (int i = 0; i < n; i++)
            {
                raw[i] = i;
                perm[i] = i;
            }

            int step = 0;
            while (true)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    if (i%2==0)
                    {
                        arr[i] = perm[i / 2];
                    }
                    else
                    {
                        arr[i] = perm[n / 2 + (i - 1) / 2];
                    }
                }

                perm = arr;
                step++;
                if (Enumerable.SequenceEqual(raw,perm))
                {
                    break;
                }
            }

            return step;
        }
    }
}