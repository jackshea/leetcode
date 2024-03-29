﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Hard;

/// 使所有区间的异或结果为零
/// https://leetcode-cn.com/problems/make-the-xor-of-all-segments-equal-to-zero/
public class P1787_MakeTheXorOfAllSegmentsEqualToZero
{
    // x 的范围为 [0, 2^10)
    private const int MAXX = 1 << 10;

    // 极大值，为了防止整数溢出选择 INT_MAX / 2
    private const int INFTY = int.MaxValue / 2;

    public int MinChanges(int[] nums, int k)
    {
        var n = nums.Length;
        var f = new int[MAXX];
        Array.Fill(f, INFTY);
        // 边界条件 f(-1,0)=0
        f[0] = 0;

        for (var i = 0; i < k; ++i)
        {
            // 第 i 个组的哈希映射
            var cnt = new Dictionary<int, int>();
            var size = 0;
            for (var j = i; j < n; j += k)
            {
                if (!cnt.ContainsKey(nums[j]))
                    cnt.Add(nums[j], 1);
                else
                    ++cnt[nums[j]];
                ++size;
            }

            // 求出 t2
            var t2min = f.Min();

            var g = new int[MAXX];
            Array.Fill(g, t2min);
            for (var mask = 0; mask < MAXX; ++mask)
                // t1 则需要枚举 x 才能求出
                foreach (var entry in cnt)
                {
                    int x = entry.Key, countx = entry.Value;
                    g[mask] = Math.Min(g[mask], f[mask ^ x] - countx);
                }

            // 别忘了加上 size
            for (var j = 0; j < MAXX; ++j) g[j] += size;
            f = g;
        }

        return f[0];
    }
}