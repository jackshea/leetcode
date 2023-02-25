using System;

namespace LeetCode.Problems.Easy;

/// 翻转数位
/// https://leetcode-cn.com/problems/reverse-bits-lcci/
public class MST0503
{
    public int ReverseBits(int num)
    {
        int max = 0, cur = 0, pre = 0;
        while (num > 0)
        {
            if (num % 2 == 0)
            {
                max = Math.Max(max, cur + pre + 1);
                pre = cur;
                cur = 0;
            }
            else
            {
                cur++;
            }

            num /= 2;
        }

        max = Math.Max(max, cur + pre + 1);
        return max;
    }
}