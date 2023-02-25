using System;

namespace LeetCode.Problems.Medium.P0478;

/// 在圆内随机生成点
/// https://leetcode-cn.com/problems/generate-random-point-in-a-circle/
public class Solution
{
    private readonly double _radius;
    private readonly double _xCenter;
    private readonly double _yCenter;
    private readonly Random rand;
    private readonly double rr;

    public Solution(double radius, double x_center, double y_center)
    {
        _yCenter = y_center;
        _xCenter = x_center;
        _radius = radius;
        rr = radius * radius;
        rand = new Random((int)DateTime.Now.Ticks);
    }

    public double[] RandPoint()
    {
        double x = 0;
        double y = 0;
        do
        {
            x = GetRandom(_xCenter - _radius, _xCenter + _radius);
            y = GetRandom(_yCenter - _radius, _yCenter + _radius);
        } while ((x - _xCenter) * (x - _xCenter) + (y - _yCenter) * (y - _yCenter) > rr);

        return new[] { x, y };
    }

    private double GetRandom(double start, double end)
    {
        return start + (end - start) * rand.NextDouble();
    }
}