using System;

namespace LeetCode.Problems.Easy;

/// 卡车上的最大单元数
/// https://leetcode-cn.com/problems/maximum-units-on-a-truck/
public class P1710_MaximumUnitsOnATruck
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        Array.Sort(boxTypes, (a, b) => -a[1].CompareTo(b[1]));
        var ans = 0;
        for (var i = 0; i < boxTypes.Length; i++)
            if (boxTypes[i][0] <= truckSize)
            {
                ans += boxTypes[i][1] * boxTypes[i][0];
                truckSize -= boxTypes[i][0];
            }
            else
            {
                ans += boxTypes[i][1] * truckSize;
                break;
            }

        return ans;
    }
}