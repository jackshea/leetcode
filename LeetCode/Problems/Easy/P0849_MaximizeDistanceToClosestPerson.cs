using System;

namespace LeetCode.Problems.Easy
{
    /// 到最近的人的最大距离
    /// https://leetcode-cn.com/problems/maximize-distance-to-closest-person/
    public class P0849_MaximizeDistanceToClosestPerson
    {
        public int MaxDistToClosest(int[] seats)
        {
            int last = 0;
            int maxDist = 0;
            int dist = 0;
            bool first = true;

            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 0)
                    continue;

                dist = i - last;
                if (!first)
                {
                    dist /= 2;
                }

                maxDist = Math.Max(maxDist, dist);
                last = i;
                first = false;
            }

            var end = seats.Length - 1;
            if (seats[end] == 0 && maxDist < end - last)
            {
                maxDist = end - last;
            }

            return maxDist;
        }
    }
}