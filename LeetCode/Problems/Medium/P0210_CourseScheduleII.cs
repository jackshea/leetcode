using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 课程表 II
    /// https://leetcode-cn.com/problems/course-schedule-ii/
    public class P0210_CourseScheduleII
    {
        private Stack<int> order = new Stack<int>();
        private List<int>[] adj;
        private int[] visited;// 0=未搜索，1=搜索中，2=已完成
        private bool valid = true;

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            adj = new List<int>[numCourses];
            visited = new int[numCourses];
            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new List<int>();
            }
            foreach (var p in prerequisites)
            {
                adj[p[0]].Add(p[1]);
            }

            for (int i = 0; i < numCourses && valid; i++)
            {
                if (visited[i] == 0)
                {
                    DFS(i);
                }
            }

            if (valid)
            {
                int[] ans = new int[order.Count];
                for (int i = ans.Length - 1; i >= 0; i--)
                {
                    ans[i] = order.Pop();
                }

                return ans;
            }

            return new int[0];
        }

        private void DFS(int curCourse)
        {
            visited[curCourse] = 1;
            foreach (var v in adj[curCourse])
            {
                if (visited[v] == 0)
                {
                    DFS(v);
                    if (!valid)
                    {
                        return;
                    }
                }
                else if (visited[v] == 1)
                {
                    valid = false;
                    return;
                }
            }

            visited[curCourse] = 2;
            order.Push(curCourse);
        }
    }
}