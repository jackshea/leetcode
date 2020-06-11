using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 每日温度
    /// https://leetcode-cn.com/problems/daily-temperatures/
    public class P0739_DailyTemperatures
    {
        public int[] DailyTemperatures(int[] T)
        {
            Stack<int> stack = new Stack<int>();
            int[] ans = new int[T.Length];
            for (int i = 0; i < T.Length; i++)
            {
                int t = T[i];
                while (stack.Count != 0)
                {
                    var topIndex = stack.Peek();
                    if (T[topIndex] < t)
                    {
                        stack.Pop();
                        ans[topIndex] = i - topIndex;
                    }
                    else
                    {
                        break;
                    }
                }
                stack.Push(i);
            }

            return ans;
        }
    }
}