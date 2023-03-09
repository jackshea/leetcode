using System;

namespace LeetCode.Problems.Easy;

/// 得到 K 个黑块的最少涂色次数
/// https://leetcode.cn/problems/minimum-recolors-to-get-k-consecutive-black-blocks/
public class P2379_MinimumRecolorsToGetKConsecutiveBlackBlocks
{
    public int MinimumRecolors(string blocks, int k)
    {
        int wCount = 0; // 滑动窗口内白块的数量
        for (int i = 0; i < k; i++)
        {
            if (blocks[i] == 'W')
            {
                wCount++;
            }
        }

        int ans = wCount;
        for (int i = k; i < blocks.Length; i++)
        {
            if (blocks[i] == 'W')
            {
                wCount++;
            }

            if (blocks[i - k] == 'W')
            {
                wCount--;
            }

            ans = Math.Min(ans, wCount);
        }
        return ans;
    }
}