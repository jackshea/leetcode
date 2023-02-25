using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 直线上最多的点数
/// https://leetcode-cn.com/problems/max-points-on-a-line/
public class P0149_MaxPointsOnALine
{
    public int MaxPoints(int[][] points)
    {
        var n = points.Length;
        if (n <= 2) return n;
        var ret = 0;
        for (var i = 0; i < n; i++)
        {
            if (ret >= n - i || ret > n / 2) break;
            var dictionary = new Dictionary<int, int>();
            for (var j = i + 1; j < n; j++)
            {
                var x = points[i][0] - points[j][0];
                var y = points[i][1] - points[j][1];
                if (x == 0)
                {
                    y = 1;
                }
                else if (y == 0)
                {
                    x = 1;
                }
                else
                {
                    if (y < 0)
                    {
                        x = -x;
                        y = -y;
                    }

                    var gcdXY = gcd(Math.Abs(x), Math.Abs(y));
                    x /= gcdXY;
                    y /= gcdXY;
                }

                var key = y + x * 20001;
                if (!dictionary.ContainsKey(key))
                    dictionary.Add(key, 1);
                else
                    dictionary[key]++;
            }

            var maxn = 0;
            foreach (var num in dictionary.Values) maxn = Math.Max(maxn, num + 1);
            ret = Math.Max(ret, maxn);
        }

        return ret;
    }

    public int gcd(int a, int b)
    {
        return b != 0 ? gcd(b, a % b) : a;
    }
}