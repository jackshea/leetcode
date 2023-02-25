using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Hard;

/// 滑动谜题
/// https://leetcode-cn.com/problems/sliding-puzzle/
public class P0773_SlidingPuzzle
{
    private readonly int[][] neighbors = new int[6][]
        { new[] { 1, 3 }, new[] { 0, 2, 4 }, new[] { 1, 5 }, new[] { 0, 4 }, new[] { 1, 3, 5 }, new[] { 2, 4 } };

    public int SlidingPuzzle(int[][] board)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < 2; i++)
        for (var j = 0; j < 3; j++)
            sb.Append(board[i][j]);

        var startString = sb.ToString();
        if (startString == "123450") return 0;

        var step = 0;
        var visited = new HashSet<string>();
        var q = new Queue<string>();
        q.Enqueue(startString);
        visited.Add(startString);
        while (q.Count > 0)
        {
            step++;
            var qCount = q.Count;
            for (var i = 0; i < qCount; i++)
            {
                var top = q.Dequeue();
                foreach (var nextState in GetNextStates(top))
                {
                    if (nextState == "123450") return step;
                    if (visited.Contains(nextState)) continue;
                    q.Enqueue(nextState);
                    visited.Add(nextState);
                }
            }
        }

        return -1;
    }

    public List<string> GetNextStates(string current)
    {
        var pos = current.IndexOf('0');
        var chars = current.ToCharArray();
        var nextStates = new List<string>();
        foreach (var nei in neighbors[pos])
        {
            Swap(chars, pos, nei);
            nextStates.Add(new string(chars));
            Swap(chars, pos, nei);
        }

        return nextStates;
    }

    public void Swap(char[] chars, int a, int b)
    {
        var temp = chars[a];
        chars[a] = chars[b];
        chars[b] = temp;
    }
}