using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 在系统中查找重复文件
    /// https://leetcode-cn.com/problems/find-duplicate-file-in-system/
    public class P0609_FindDuplicateFileInSystem
    {
        public IList<IList<string>> FindDuplicate(string[] paths)
        {
            var content2fileName = new Dictionary<string, List<string>>();
            char[] splitChars = "()".ToCharArray();
            foreach (var path in paths)
            {
                var pathSplit = path.Split(' ');
                string root = pathSplit[0];
                for (int i = 1; i < pathSplit.Length; i++)
                {
                    var file = pathSplit[i].Split(splitChars);
                    if (!content2fileName.TryGetValue(file[1], out var files))
                    {
                        files = new List<string>();
                        content2fileName.Add(file[1], files);
                    }
                    files.Add(root + "/" + file[0]);
                }
            }

            IList<IList<string>> ans = new List<IList<string>>();
            foreach (var kvp in content2fileName)
            {
                if (kvp.Value.Count>1)
                {
                    ans.Add(kvp.Value);
                }
            }

            return ans;
        }
    }
}