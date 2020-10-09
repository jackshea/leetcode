using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 根据身高重建队列
    /// https://leetcode-cn.com/problems/queue-reconstruction-by-height/
    public class P0406_QueueReconstructionByHeight
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort(people, (a, b) =>
            {
                if (a[0] == b[0])
                {
                    return a[1].CompareTo(b[1]);
                }

                return -a[0].CompareTo(b[0]);
            });

            List<int[]> ans = new List<int[]>(people.Length);
            foreach (var p in people)
            {
                ans.Insert(p[1], p);
            }

            return ans.ToArray();
        }
    }
}