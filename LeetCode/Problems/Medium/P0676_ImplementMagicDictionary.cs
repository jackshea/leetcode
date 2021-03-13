using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 实现一个魔法字典
    /// https://leetcode-cn.com/problems/implement-magic-dictionary/
    public class MagicDictionary
    {
        private HashSet<string> dic = new HashSet<string>();
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
                    dic.Add(new string(charArray));
                    charArray[i] = c;
                }
            }
        }

        public bool Search(string searchWord)
        {
            if (rawDic.Contains(searchWord))
            {
                return false;
            }

            var charArray = searchWord.ToCharArray();
            for (var i = 0; i < charArray.Length; i++)
            {
                var c = charArray[i];
                charArray[i] = '?';
                if (dic.Contains(new string(charArray)))
                {
                    return true;
                }
                charArray[i] = c;
            }

            return false;
        }
    }
}