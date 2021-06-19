using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 串联字符串的最大长度
    /// https://leetcode-cn.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/
    public class P1239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters
    {
        private int ans;

        public int MaxLength(IList<string> arr)
        {
            List<int> masks = new List<int>();
            foreach (var word in arr)
            {
                int mask = 0;
                foreach (var c in word)
                {
                    int bit = 1 << (c - 'a');
                    if ((mask & bit) != 0)
                    {
                        mask = -1;
                        break;
                    }

                    mask |= bit;
                }

                if (mask > 0)
                {
                    masks.Add(mask);
                }
            }

            Backtrack(masks, 0, 0);
            return ans;
        }

        public void Backtrack(List<int> masks, int start, int curMask)
        {
            if (start >= masks.Count)
            {
                ans = Math.Max(ans, HammingWeight(curMask));
                return;
            }

            var mask = masks[start];
            if ((curMask & mask) == 0)
            {
                Backtrack(masks, start + 1, curMask | mask);
            }
            Backtrack(masks, start + 1, curMask);
        }

        public int HammingWeight(int n)
        {
            int ans = 0;
            while (n != 0)
            {
                n &= n - 1;
                ans++;
            }

            return ans;
        }
    }
}