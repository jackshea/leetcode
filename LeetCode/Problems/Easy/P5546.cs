using System;

namespace LeetCode.Problems.Easy
{
    /// 按键持续时间最长的键
    /// https://leetcode-cn.com/contest/weekly-contest-212/problems/slowest-key/
    public class P5546
    {
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            int[] key = new int[26];
            for (int i = 0; i < releaseTimes.Length; i++)
            {
                int c = keysPressed[i] - 'a';
                if (i == 0)
                {
                    key[c] = releaseTimes[i];
                    continue;
                }
                key[c] = Math.Max(key[c], releaseTimes[i] - releaseTimes[i - 1]);
            }

            int max = 0;
            char ans = 'a';
            for (int i = 0; i < 26; i++)
            {
                if (max <= key[i])
                {
                    max = key[i];
                    ans = (char)('a' + i);
                }
            }

            return ans;
        }
    }
}