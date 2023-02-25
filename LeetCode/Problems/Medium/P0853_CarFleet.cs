using System;

namespace LeetCode.Problems.Medium;

/// 车队
/// https://leetcode-cn.com/problems/car-fleet/
public class P0853_CarFleet
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var n = position.Length;
        var cars = new Car[n];
        for (var i = 0; i < n; i++)
            cars[i] = new Car { Position = position[i], Time = 1.0 * (target - position[i]) / speed[i] };
        Array.Sort(cars, (a, b) => a.Position.CompareTo(b.Position));
        int ans = 0, t = n;
        while (--t > 0)
            if (cars[t].Time < cars[t - 1].Time)
                ans++;
            else
                cars[t - 1].Time = cars[t].Time;

        return ans + (t == 0 ? 1 : 0);
    }

    private class Car
    {
        public int Position;
        public double Time;
    }
}