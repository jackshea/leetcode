using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 最近的请求次数
    /// https://leetcode-cn.com/problems/number-of-recent-calls/
    public class RecentCounter
    {
        private Queue<int> lastPings;
        public RecentCounter()
        {
            lastPings = new Queue<int>();
        }

        public int Ping(int t)
        {
            while (lastPings.Count > 0 && lastPings.Peek() < t - 3000)
            {
                lastPings.Dequeue();
            }
            lastPings.Enqueue(t);
            return lastPings.Count;
        }
    }
}