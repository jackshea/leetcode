using System;

namespace LeetCode.Problems.Medium
{
    /// 任务调度器
    /// https://leetcode-cn.com/problems/task-scheduler/
    public class P0621_TaskScheduler
    {
        public int LeastInterval(char[] tasks, int n)
        {
            if (n == 0)
            {
                return tasks.Length;
            }
            int[] cnt = new int[26];
            int maxExe = 0;
            int maxCount = 0;
            foreach (var task in tasks)
            {
                int currentCnt = ++cnt[task - 'A'];
                if (currentCnt == maxExe)
                {
                    maxCount++;
                }
                else if (currentCnt > maxExe)
                {
                    maxExe = currentCnt;
                    maxCount = 1;
                }
            }

            var fillCnt = (maxExe - 1) * (n + 1) + maxCount;
            return Math.Max(fillCnt, tasks.Length);
        }
    }
}