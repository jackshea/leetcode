﻿namespace LeetCode.Problems.Medium
{
    /// 解码异或后的排列
    /// https://leetcode-cn.com/problems/decode-xored-permutation/
    public class P1734_DecodeXoredPermutation
    {
        public int[] Decode(int[] encoded)
        {
            int n = encoded.Length + 1;
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                total ^= i;
            }

            int odd = 0;
            for (int i = 1; i < n - 1; i += 2)
            {
                odd ^= encoded[i];
            }
            int[] perm = new int[n];
            perm[0] = total ^ odd;
            for (int i = 0; i < n - 1; i++)
            {
                perm[i + 1] = perm[i] ^ encoded[i];
            }

            return perm;
        }
    }
}