using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems
{
    /// 最短完整词
    /// https://leetcode-cn.com/problems/shortest-completing-word/
    public class P0748_ShortestCompletingWord
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var licenseDic = GetDic(licensePlate);
            int count = licenseDic.Values.Sum();

            string ans = string.Empty;
            int length = int.MaxValue;

            foreach (var word in words)
            {
                if (word.Length < count)
                {
                    continue;
                }

                var wordDic = GetDic(word);
                bool isMatch = true;
                foreach (var kvp in licenseDic)
                {
                    int v = 0;
                    if (!wordDic.TryGetValue(kvp.Key, out v) || v < kvp.Value)
                    {
                        isMatch = false;
                        break;
                    }
                }

                if (isMatch && word.Length < length)
                {
                    ans = word;
                    length = word.Length;
                }
            }

            return ans;
        }

        private Dictionary<char, int> GetDic(string word)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in word)
            {
                if (!char.IsLetter(c))
                {
                    continue;
                }

                char toLower = char.ToLower(c);
                if (dic.ContainsKey(toLower))
                {
                    dic[toLower]++;
                }
                else
                {
                    dic[toLower] = 1;
                }
            }

            return dic;
        }
    }
}