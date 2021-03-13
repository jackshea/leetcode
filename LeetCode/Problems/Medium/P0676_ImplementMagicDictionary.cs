using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 实现一个魔法字典
    /// https://leetcode-cn.com/problems/implement-magic-dictionary/
    public class MagicDictionary
    {
        private Dictionary<string, int> dic = new Dictionary<string, int>();
        private HashSet<string> rawDic = new HashSet<string>();

        /** Initialize your data structure here. */
        public MagicDictionary()
        {

        }

        public void BuildDict(string[] dictionary)
        {
            foreach (var word in dictionary)
            {
                rawDic.Add(word);
                var charArray = word.ToCharArray();
                for (var i = 0; i < charArray.Length; i++)
                {
                    var c = charArray[i];
                    charArray[i] = '?';
                    var key = new string(charArray);
                    dic.TryGetValue(key, out var count);
                    dic[key] = count + 1;
                    charArray[i] = c;
                }
            }
        }

        public bool Search(string searchWord)
        {
            var charArray = searchWord.ToCharArray();
            for (var i = 0; i < charArray.Length; i++)
            {
                var c = charArray[i];
                charArray[i] = '?';
                var key = new string(charArray);
                charArray[i] = c;
                dic.TryGetValue(key, out var count);
                if (count == 1 && rawDic.Contains(searchWord))
                {
                    continue;
                }

                if (count >= 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}