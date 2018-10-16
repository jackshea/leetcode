using System;
using System.Text;

namespace LeetCode.Problems
{
    /// 报数
    /// https://leetcode-cn.com/problems/count-and-say/hints/
    public class P0038_CountAndSay
    {
        public string CountAndSay(int n)
        {
            string lastString = "1";

            for (int i = 1; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();
                char lastChar = lastString[0];
                int lastCount = 1;
                for (int j = 1; j < lastString.Length; j++)
                {
                    var c = lastString[j];
                    if (lastChar != c)
                    {
                        sb.Append(lastCount);
                        sb.Append(lastChar);
                        lastChar = c;
                        lastCount = 1;
                    }
                    else
                    {
                        lastCount++;
                    }
                }

                sb.Append(lastCount);
                sb.Append(lastChar);

                lastString = sb.ToString();
            }

            return lastString;
        }
    }
}