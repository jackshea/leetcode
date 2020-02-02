using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 单词规律
    /// https://leetcode-cn.com/problems/word-pattern/
    public class P0290_WordPattern
    {
        public bool WordPattern(string pattern, string str)
        {
            string[] targets = str.Split(' ');
            if (pattern.Length != targets.Length)
            {
                return false;
            }

            Dictionary<char, string> pattern2Target = new Dictionary<char, string>();
            HashSet<string> existString = new HashSet<string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                char c = pattern[i];
                var target = targets[i];
                if (pattern2Target.ContainsKey(c))
                {
                    if (pattern2Target[c] != target)
                    {
                        return false;
                    }
                }
                else
                {
                    if (existString.Contains(target))
                    {
                        return false;
                    }
                    pattern2Target[c] = target;
                    existString.Add(target);
                }
            }

            return true;
        }
    }
}