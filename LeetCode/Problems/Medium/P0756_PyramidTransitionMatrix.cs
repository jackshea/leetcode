using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 金字塔转换矩阵
/// https://leetcode-cn.com/problems/pyramid-transition-matrix/
public class P0756_PyramidTransitionMatrix
{
    public bool PyramidTransition(string bottom, IList<string> allowed)
    {
        return DFS(bottom, allowed, new List<char>(), 0);
    }

    private bool DFS(string floor, IList<string> allowed, List<char> currentLine, int index)
    {
        if (floor.Length == 2 && currentLine.Count == 1) return true;

        if (index > floor.Length - 1) return false;

        if (index == floor.Length - 1) return DFS(new string(currentLine.ToArray()), allowed, new List<char>(), 0);

        for (var i = 0; i < allowed.Count; i++)
            if (allowed[i][0] == floor[index] && allowed[i][1] == floor[index + 1])
            {
                currentLine.Add(allowed[i][2]);
                if (DFS(floor, allowed, currentLine, index + 1)) return true;
                currentLine.RemoveAt(currentLine.Count - 1);
            }

        return false;
    }
}