using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Medium;

/// 删除注释
/// https://leetcode-cn.com/problems/remove-comments/
public class P0722_RemoveComments
{
    public IList<string> RemoveComments(string[] source)
    {
        IList<string> ans = new List<string>();
        var inBlock = false;
        var newLine = new StringBuilder();
        foreach (var line in source)
        {
            if (!inBlock) newLine = new StringBuilder();
            for (var i = 0; i < line.Length; i++)
                if (inBlock)
                {
                    if (i + 1 < line.Length && line[i] == '*' && line[i + 1] == '/')
                    {
                        inBlock = false;
                        i++;
                    }
                }
                else
                {
                    if (i + 1 < line.Length && line[i] == '/' && line[i + 1] == '/') break;

                    if (i + 1 < line.Length && line[i] == '/' && line[i + 1] == '*')
                    {
                        inBlock = true;
                        i++;
                    }
                    else
                    {
                        newLine.Append(line[i]);
                    }
                }

            if (!inBlock && newLine.Length > 0) ans.Add(newLine.ToString());
        }

        return ans;
    }
}