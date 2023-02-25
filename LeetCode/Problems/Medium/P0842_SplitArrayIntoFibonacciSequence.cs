using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 将数组拆分成斐波那契序列
/// https://leetcode-cn.com/problems/split-array-into-fibonacci-sequence/
public class P0842_SplitArrayIntoFibonacciSequence
{
    public IList<int> SplitIntoFibonacci(string S)
    {
        var ans = new List<int>();
        Backtrack(ans, S, 0, 0, 0);
        return ans;
    }

    private bool Backtrack(List<int> list, string s, int start, int last1, int last2)
    {
        if (start >= s.Length) return list.Count >= 3;

        long longCurr = 0;
        for (var i = start; i < s.Length; i++)
        {
            if (s[start] == '0' && i > start) break;
            longCurr = longCurr * 10 + (s[i] - '0');
            if (longCurr > int.MaxValue) break;

            var curr = (int)longCurr;
            if (list.Count >= 2)
            {
                if (curr < last1 + last2)
                    continue;
                if (curr > last1 + last2) break;
            }

            list.Add(curr);
            if (Backtrack(list, s, i + 1, last2, curr))
                return true;
            list.RemoveAt(list.Count - 1);
        }

        return false;
    }
}