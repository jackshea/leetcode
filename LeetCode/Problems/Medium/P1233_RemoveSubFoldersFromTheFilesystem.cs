using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 删除子文件夹
/// https://leetcode.cn/problems/remove-sub-folders-from-the-filesystem/
public class P1233_RemoveSubFoldersFromTheFilesystem
{
    public IList<string> RemoveSubfolders(string[] folder)
    {
        Array.Sort(folder);
        IList<string> ans = new List<string>();
        ans.Add(folder[0]);
        for (var i = 1; i < folder.Length; i++)
        {
            var last = ans[^1];
            var cur = folder[i];
            if (cur.Length > last.Length && cur[last.Length] == '/' && cur.StartsWith(last))
            {
                // do nothing
            }
            else
            {
                ans.Add(cur);
            }
        }

        return ans;
    }
}