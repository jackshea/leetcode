namespace LeetCode.Problems.Medium
{
    /// 加油站
    /// https://leetcode-cn.com/problems/gas-station/
    public class P0134_GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int allDiff = 0;
            int remain = 0;
            int start = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                int diff = gas[i] - cost[i];
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
}