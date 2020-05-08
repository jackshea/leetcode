using System.Text;

namespace LeetCode.Problems.Medium
{
    /// 二进制数转字符串
    /// https://leetcode-cn.com/problems/bianry-number-to-string-lcci/
    public class MST0502
    {
        public string PrintBin(double num)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("0.");
            for (int i = 0; i < 30; i++)
            {
                num *= 2;
                if (num >= 1)
                {
                    sb.Append('1');
                    num -= 1;
                }
                else
                {
                    sb.Append('0');
                }

                if (num == 0)
                {
                    return sb.ToString();
                }
            }

            return "ERROR";
        }
    }
}