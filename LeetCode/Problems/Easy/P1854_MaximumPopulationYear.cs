namespace LeetCode.Problems.Easy;

/// 人口最多的年份
/// https://leetcode-cn.com/problems/maximum-population-year/
public class P1854_MaximumPopulationYear
{
    public int MaximumPopulation(int[][] logs)
    {
        var pop = new int[101];
        foreach (var log in logs)
            for (var i = log[0] - 1950; i < log[1] - 1950; i++)
                pop[i]++;

        var ans = 0;
        var max = 0;
        for (var i = 0; i < pop.Length; i++)
            if (pop[i] > max)
            {
                max = pop[i];
                ans = i;
            }

        return ans + 1950;
    }
}