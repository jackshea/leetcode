using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Easy
{
    /// 解密消息
    /// https://leetcode.cn/problems/decode-the-message/
    public class P2325_DecodeTheMessage
    {
        public string DecodeMessage(string key, string message)
        {
            var dic = new Dictionary<char, char>();
            var index = 'a';
            foreach (var c in key)
            {
                if (c != ' ' && !dic.ContainsKey(c))
                {
                    dic.Add(c, index++);
                }

                if (index > 'z')
                {
                    break;
                }
            }

            StringBuilder sb = new StringBuilder(26);
            foreach (var c in message)
            {
                if (c == ' ')
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append(dic[c]);
                }
            }

            return sb.ToString();
        }
    }
}