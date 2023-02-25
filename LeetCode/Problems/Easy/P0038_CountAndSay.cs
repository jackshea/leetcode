using System.Text;

namespace LeetCode.Problems.Easy;

/// 报数
/// https://leetcode-cn.com/problems/count-and-say/hints/
public class P0038_CountAndSay
{
    public string CountAndSay(int n)
    {
        var lastString = "1";

        for (var i = 1; i < n; i++)
        {
            var sb = new StringBuilder();
            var lastChar = lastString[0];
            var lastCount = 1;
            for (var j = 1; j < lastString.Length; j++)
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