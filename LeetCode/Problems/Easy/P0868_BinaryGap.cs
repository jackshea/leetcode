using System;

namespace LeetCode.Problems
{
    /// 二进制间距
    /// https://leetcode-cn.com/problems/binary-gap/
    public class P0868_BinaryGap
    {
        public int BinaryGap(int N)
        {
            var bin = Convert.ToString(N, 2);
            int lastIndex = -1;
            int ans = 0;

            for (var i = 0; i < bin.Length; i++)
            {
                var c = bin[i];
                if (c == '1')
                {
                    if (lastIndex != -1)
                    {
                        ans = Math.Max(ans, i - lastIndex);
                    }

                    lastIndex = i;
                }
            }

            return ans;
        }
    }
}