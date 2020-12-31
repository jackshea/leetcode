using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 砖墙
    /// https://leetcode-cn.com/problems/brick-wall/
    public class P0554_BrickWall
    {
        public int LeastBricks(IList<IList<int>> wall)
        {
            int len = wall[0].Sum();
            Dictionary<int, int> interval = new Dictionary<int, int>();
            for (int i = 0; i < wall.Count; i++)
            {
                int sum = 0;
                for (int j = 0; j < wall[i].Count; j++)
                {
                    sum += wall[i][j];
                    if (sum >= len)
                    {
                        continue;
                    }

                    var cnt = 0;
                    interval.TryGetValue(sum, out cnt);
                    interval[sum] = cnt + 1;
                }
            }

            int max = 0;
            foreach (var value in interval.Values)
            {
                max = Math.Max(max, value);
            }

            return wall.Count - max;
        }
    }
}