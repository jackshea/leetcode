using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 钥匙和房间
    /// https://leetcode-cn.com/problems/keys-and-rooms/
    public class P0841_KeysAndRooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            bool[] visited = new bool[rooms.Count];
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            visited[0] = true;
            while (q.Count != 0)
            {
                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    var top = q.Dequeue();
                    visited[top] = true;
                    foreach (var key in rooms[top])
                    {
                        if (!visited[key])
                        {
                            q.Enqueue(key);
                        }
                    }
                }
            }
            foreach (var v in visited)
            {
                if (!v)
                {
                    return false;
                }
            }

            return true;
        }
    }
}