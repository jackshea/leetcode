using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 每日温度
/// https://leetcode-cn.com/problems/daily-temperatures/
public class P0739_DailyTemperatures
{
    public int[] DailyTemperatures(int[] T)
    {
        var stack = new Stack<int>();
        var ans = new int[T.Length];
        for (var i = 0; i < T.Length; i++)
        {
            var t = T[i];
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