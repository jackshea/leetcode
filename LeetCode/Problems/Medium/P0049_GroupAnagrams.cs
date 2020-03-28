using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 字母异位词分组
    /// https://leetcode-cn.com/problems/group-anagrams/
    public class P0049_GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                var keyCA = str.ToCharArray();
                Array.Sort(keyCA);
                string key = new string(keyCA);
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(str);
                }
                else
                {
                    dic[key] = new List<string> { str };
                }
            }
            IList<IList<string>> ans = new List<IList<string>>();
            foreach (var key in dic.Keys)
            {
                var row = new List<string>();
                foreach (var s in dic[key])
                {
                    row.Add(s);
                }
                ans.Add(row);
            }

            return ans;
        }
    }
}