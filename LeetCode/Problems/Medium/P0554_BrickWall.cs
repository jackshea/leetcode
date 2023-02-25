using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium;

/// 砖墙
/// https://leetcode-cn.com/problems/brick-wall/
public class P0554_BrickWall
{
    public int LeastBricks(IList<IList<int>> wall)
    {
        var len = wall[0].Sum();
        var interval = new Dictionary<int, int>();
        for (var i = 0; i < wall.Count; i++)
        {
            var sum = 0;
            for (var j = 0; j < wall[i].Count; j++)
            {
                sum += wall[i][j];
                if (sum >= len) continue;

                var cnt = 0;
                interval.TryGetValue(sum, out cnt);
                interval[sum] = cnt + 1;
            }
        }

        var max = 0;
        foreach (var value in interval.Values) max = Math.Max(max, value);

        return wall.Count - max;
    }
}