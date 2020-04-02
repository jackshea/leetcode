using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Medium
{
    /// 第k个排列
    /// https://leetcode-cn.com/problems/permutation-sequence/
    public class P0060_PermutationSequence
    {
        public string GetPermutation(int n, int k)
        {
            StringBuilder sb = new StringBuilder();
            int[] factorial = new int[10];
            factorial[0] = 1;
            for (int i = 1; i < 10; i++)
            {
                factorial[i] = i * factorial[i - 1];
            }

            List<int> num = new List<int>();
            for (int i = 1; i <= 9; i++)
            {
                num.Add(i);
            }

            k--;
            for (int i = n - 1; i >= 0; i--)
            {
                var index = k / factorial[i];
                k -= index * factorial[i];
                sb.Append(num[index]);
                num.RemoveAt(index);
            }

            return sb.ToString();
        }
    }
}