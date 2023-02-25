using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Hard;

/// 自由之路
/// https://leetcode-cn.com/problems/freedom-trail/
public class P0514_FreedomTrail
{
    public int FindRotateSteps(string ring, string key)
    {
        var pos = new List<int>[26];
        for (var i = 0; i < pos.Length; i++) pos[i] = new List<int>();

        for (var i = 0; i < ring.Length; i++) pos[ring[i] - 'a'].Add(i);

        var dp0 = new int[ring.Length];
        var dp1 = new int[ring.Length];
        for (var i = 0; i < ring.Length; i++)
        {
            dp0[i] = int.MaxValue / 2;
            dp1[i] = int.MaxValue / 2;
        }

        foreach (var p in pos[key[0] - 'a']) dp1[p] = Math.Min(p, ring.Length - p) + 1;

        for (var i = 1; i < key.Length; i++)
        {
            var temp = dp0;
            dp0 = dp1;
            dp1 = temp;
            for (var d = 0; d < ring.Length; d++) dp1[d] = int.MaxValue / 2;
            foreach (var p1 in pos[key[i] - 'a'])
            foreach (var p0 in pos[key[i - 1] - 'a'])
            {
                var dist = Math.Abs(p0 - p1);
                dp1[p1] = Math.Min(dp1[p1], 1 + dp0[p0] + Math.Min(dist, ring.Length - dist));
            }
        }

        return dp1.Min();
    }
}