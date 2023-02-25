using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Medium;

/// 简化路径
/// https://leetcode-cn.com/problems/simplify-path/
public class P0071_SimplifyPath
{
    public string SimplifyPath(string path)
    {
        var pathStack = new Stack<string>();
        var pathSplit = path.Split('/');
        foreach (var dir in pathSplit)
        {
            if (string.IsNullOrEmpty(dir) || dir == ".") continue;

            if (dir == "..")
            {
                if (pathStack.Count > 0) pathStack.Pop();
            }
            else
            {
                pathStack.Push(dir);
            }
        }

        var dirs = pathStack.ToArray();
        var sb = new StringBuilder();
        for (var i = dirs.Length - 1; i >= 0; i--) sb.Append("/" + dirs[i]);

        if (sb.Length == 0) sb.Append("/");
        return sb.ToString();
    }
}