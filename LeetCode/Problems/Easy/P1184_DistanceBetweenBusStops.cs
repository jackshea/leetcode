using System;

namespace LeetCode.Problems.Easy
{
    /// 公交站间的距离
    /// https://leetcode-cn.com/problems/distance-between-bus-stops/
    public class P1184_DistanceBetweenBusStops
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int pathDist = 0;
            int sumDist = 0;
            if (start > destination)
            {
                int temp = start;
                start = destination;
                destination = temp;
            }

            for (int i = 0; i < distance.Length; i++)
            {
                sumDist += distance[i];
                if (i >= start && i < destination)
                {
                    pathDist += distance[i];
                }
            }

            return Math.Min(pathDist, sumDist - pathDist);
        }
    }
}