using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 扰乱字符串
    /// https://leetcode-cn.com/problems/scramble-string/
    public class P0087_ScrambleString
    {
        // 记忆化搜索存储状态的数组
        // -1 表示 false，1 表示 true，0 表示未计算
        int[,,] memo;
        string s1, s2;

        public bool IsScramble(string s1, string s2)
        {
            int length = s1.Length;
            memo = new int[length, length, length + 1];

            this.s1 = s1;
            this.s2 = s2;
            return DFS(0, 0, length);
        }

        // 第一个字符串从 i1 开始，第二个字符串从 i2 开始，子串的长度为 length，是否和谐
        public bool DFS(int i1, int i2, int length)
        {
            if (memo[i1, i2, length] != 0)
            {
                return memo[i1, i2, length] == 1;
            }

            // 判断两个子串是否相等
            if (s1.Substring(i1, length) == s2.Substring(i2, length))
            {
                memo[i1, i2, length] = 1;
                return true;
            }

            // 判断是否存在字符 c 在两个子串中出现的次数不同
            if (!CheckIfSimilar(i1, i2, length))
            {
                memo[i1, i2, length] = -1;
                return false;
            }

            // 枚举分割位置
            for (int i = 1; i < length; ++i)
            {
                // 不交换的情况
                if (DFS(i1, i2, i) && DFS(i1 + i, i2 + i, length - i))
                {
                    memo[i1, i2, length] = 1;
                    return true;
                }
                // 交换的情况
                if (DFS(i1, i2 + length - i, i) && DFS(i1 + i, i2, length - i))
                {
                    memo[i1, i2, length] = 1;
                    return true;
                }
            }

            memo[i1, i2, length] = -1;
            return false;
        }

        public bool CheckIfSimilar(int i1, int i2, int length)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            for (int i = i1; i < i1 + length; ++i)
            {
                char c = s1[i];
                freq.TryGetValue(c, out var count);
                freq[c] = count + 1;
            }
            for (int i = i2; i < i2 + length; ++i)
            {
                char c = s2[i];
                freq.TryGetValue(c, out var count);
                freq[c] = count - 1;
            }

            foreach (var freqValue in freq.Values)
            {
                if (freqValue != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}