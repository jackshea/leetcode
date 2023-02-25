using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 回旋镖的数量
/// https://leetcode-cn.com/problems/number-of-boomerangs/
public class P0447_NumberOfBoomerangs
{
    public int NumberOfBoomerangs(int[][] points)
    {
        var boomerangsCount = 0;
        var sameDist2Count = new Dictionary<int, int>();
        for (var i = 0; i < points.Length; i++)
        {
            for (var j = 0; j < points.Length; j++)
            {
                if (i == j) continue;
                var x = points[i][0] - points[j][0];
                var y = points[i][1] - points[j][1];
                var dist = x * x + y * y;
                if (sameDist2Count.ContainsKey(dist))
                {
                    boomerangsCount += sameDist2Count[dist] * 2;
                    sameDist2Count[dist]++;
                }
                else
                {
                    sameDist2Count.Add(dist, 1);
                }
            }

            sameDist2Count.Clear();
        }

        return boomerangsCount;
    }
}