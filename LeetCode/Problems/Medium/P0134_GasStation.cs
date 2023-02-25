namespace LeetCode.Problems.Medium;

/// 加油站
/// https://leetcode-cn.com/problems/gas-station/
public class P0134_GasStation
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var allDiff = 0;
        var remain = 0;
        var start = 0;
        for (var i = 0; i < gas.Length; i++)
        {
            var diff = gas[i] - cost[i];
            allDiff += diff;
            remain += diff;
            if (remain < 0)
            {
                remain = 0;
                start = i + 1;
            }
        }

        return allDiff < 0 ? -1 : start;
    }
}