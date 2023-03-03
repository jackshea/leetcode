using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 保证文件名唯一
/// https://leetcode.cn/problems/making-file-names-unique/
public class P1487_MakingFileNamesUnique
{
    public string[] GetFolderNames(string[] names)
    {
        var dic = new Dictionary<string, int>();
        var ans = new string[names.Length];
        for (var i = 0; i < names.Length; i++)
        {
            var name = names[i];
            if (dic.TryGetValue(name, out var index))
            {
                string newName;
                do
                {
                    newName = $"{name}({index})";
                    index++;
                } while (dic.ContainsKey(newName));

                dic[name] = index;
                dic[newName] = 1;
                ans[i] = newName;
            }
            else
            {
                dic.Add(name, 1);
                ans[i] = name;
            }
        }
        return ans;
    }
}