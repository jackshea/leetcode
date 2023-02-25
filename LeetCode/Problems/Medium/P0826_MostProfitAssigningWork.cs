using System;

namespace LeetCode.Problems.Medium;

/// 安排工作以达到最大收益
/// https://leetcode-cn.com/problems/most-profit-assigning-work/
public class P0826_MostProfitAssigningWork
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        var jobs = new Job[difficulty.Length];
        for (var i = 0; i < difficulty.Length; i++)
            jobs[i] = new Job
            {
                Difficulty = difficulty[i],
                Profit = profit[i]
            };
        Array.Sort(jobs, (a, b) => a.Difficulty.CompareTo(b.Difficulty));
        Array.Sort(worker);
        var maxProfit = 0;
        var jobIndex = 0;
        var ans = 0;
        foreach (var w in worker)
        {
            while (jobIndex < jobs.Length && w >= jobs[jobIndex].Difficulty)
            {
                maxProfit = Math.Max(maxProfit, jobs[jobIndex].Profit);
                jobIndex++;
            }

            ans += maxProfit;
        }

        return ans;
    }

    public class Job
    {
        public int Difficulty;
        public int Profit;
    }
}