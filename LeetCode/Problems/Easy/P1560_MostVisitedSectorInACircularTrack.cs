using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 圆形赛道上经过次数最多的扇区
    /// https://leetcode-cn.com/problems/most-visited-sector-in-a-circular-track/
    public class P1560_MostVisitedSectorInACircularTrack
    {
        public IList<int> MostVisited(int n, int[] rounds)
        {
            int start = rounds[0];
            int end = rounds[rounds.Length - 1];
            IList<int> ans = new List<int>();
            if (start <= end)
            {
                for (int i = start; i <= end; i++)
                {
                    ans.Add(i);
                }
            }
            else
            {
                for (int i = 1; i <= end; i++)
                {
                    ans.Add(i);
                }

                for (int i = start; i <= n; i++)
                {
                    ans.Add(i);
                }
            }

            return ans;
        }
    }
}