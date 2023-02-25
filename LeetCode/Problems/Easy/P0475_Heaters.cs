using System;

namespace LeetCode.Problems.Easy;

/// 供暖器
/// https://leetcode-cn.com/problems/heaters/submissions/
public class P0475_Heaters
{
    public int FindRadius(int[] houses, int[] heaters)
    {
        Array.Sort(houses);
        Array.Sort(heaters);
        var maxRadius = 0;
        var upper = 0;
        var houseIndex = 0;
        for (var i = 0; i < heaters.Length; i++)
        {
            if (i == heaters.Length - 1)
                upper = int.MaxValue;
            else
                upper = (heaters[i] + heaters[i + 1]) / 2;

            while (houseIndex < houses.Length && houses[houseIndex] <= upper)
            {
                maxRadius = Math.Max(maxRadius, Math.Abs(houses[houseIndex] - heaters[i]));
                houseIndex++;
            }
        }

        return maxRadius;
    }
}