using System.Text;

namespace LeetCode.Problems.Medium
{
    /// 整数转罗马数字
    /// https://leetcode-cn.com/problems/integer-to-roman/
    public class P0012_IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            StringBuilder sb = new StringBuilder();
            int m = num / 1000;
            for (int i = 0; i < m; i++)
            {
                sb.Append('M');
            }

            num %= 1000;
            sb.Append(BaseToRoman(num / 100, "C", "D", "M"));
            num %= 100;
            sb.Append(BaseToRoman(num / 10, "X", "L", "C"));
            num %= 10;
            sb.Append(BaseToRoman(num, "I", "V", "X"));
            return sb.ToString();
        }

        private string BaseToRoman(int n, string one, string five, string ten)
        {
            string[] roman = new[]
            {
                "", one, one + one, one + one + one, one + five, five,
                five + one, five + one + one,five + one + one + one, one + ten
            };
            return roman[n];
        }
    }
}