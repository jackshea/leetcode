using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 打开转盘锁
    /// https://leetcode-cn.com/problems/open-the-lock/
    public class P0752_OpenTheLock
    {
        public int OpenLock(string[] deadends, string target)
        {
            if (target == "0000")
            {
                return 0;
            }
            HashSet<string> visited = new HashSet<string>();
            foreach (var deadend in deadends)
            {
                visited.Add(deadend);
            }

            if (visited.Contains("0000"))
            {
                return -1;
            }

            Queue<string> q = new Queue<string>();
            q.Enqueue("0000");
            visited.Add("0000");
            int step = 0;
            int[] offsets = new int[] { -1, 1 };
            while (q.Count > 0)
            {
                var count = q.Count;
                step++;
                for (int i = 0; i < count; i++)
                {
                    var top = q.Dequeue().ToCharArray();
                    for (int j = 0; j < top.Length; j++)
                    {
                        char raw = top[j];
                        if (top[j] == '9')
                        {
                            top[j] = '0';
                        }
                        else
                        {
                            top[j]++;
                        }

                        var s = new string(top);
                        if (s == target)
                        {
                            return step;
                        }
                        if (!visited.Contains(s))
                        {
                            q.Enqueue(new string(top));
                            visited.Add(s);
                        }

                        top[j] = raw;
                        if (top[j] == '0')
                        {
                            top[j] = '9';
                        }
                        else
                        {
                            top[j]--;
                        }

                        s = new string(top);
                        if (s == target)
                        {
                            return step;
                        }
                        if (!visited.Contains(s))
                        {
                            q.Enqueue(new string(top));
                            visited.Add(s);
                        }

                        top[j] = raw;
                    }
                }

            }

            return -1;
        }
    }
}