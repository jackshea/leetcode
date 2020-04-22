using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 重复的DNA序列
    /// https://leetcode-cn.com/problems/repeated-dna-sequences/
    public class P0187_RepeatedDnaSequences
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i <= s.Length - 10; i++)
            {
                string sub = s.Substring(i, 10);
                if (dic.ContainsKey(sub))
                {
                    dic[sub]++;
                }
                else
                {
                    dic[sub] = 0;
                }
            }

            IList<string> ans = new List<string>();
            foreach (var kvp in dic)
            {
                if (kvp.Value > 0)
                {
                    ans.Add(kvp.Key);
                }
            }

            return ans;
        }
    }
}