using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 带因子的二叉树
    /// https://leetcode-cn.com/problems/binary-trees-with-factors/
    public class P0823_BinaryTreesWithFactors
    {
        private const int MOD = (int)1E9 + 7;
        public int NumFactoredBinaryTrees(int[] arr)
        {
            Array.Sort(arr);
            Dictionary<int, long> dic = new Dictionary<int, long>();
            foreach (var num in arr)
            {
                dic.Add(num, 1);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                for (int j = 0; j < i; j++)
                {
                    if (num % arr[j] != 0)
                    {
                        continue;
                    }

                    var div = num / arr[j];
                    if (dic.TryGetValue(div, out var cnt))
                    {
                        dic[num] = (dic[num] + dic[arr[j]] * cnt) % MOD;
                    }
                }
            }

            long ans = 0;
            foreach (var v in dic.Values)
            {
                ans += v;
            }

            return (int)(ans % MOD);
        }
    }
}