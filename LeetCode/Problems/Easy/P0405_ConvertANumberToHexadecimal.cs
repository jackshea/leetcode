namespace LeetCode.Problems.Easy
{
    /// 数字转换为十六进制数
    /// https://leetcode-cn.com/problems/convert-a-number-to-hexadecimal/
    public class P0405_ConvertANumberToHexadecimal
    {
        public string ToHex(int num)
        {
            if (num == 0)
            {
                return "0";
            }

            string ans = string.Empty;
            uint unum = (uint)num;
            while (unum != 0)
            {
                ans = ToHexChar(unum & 0b1111) + ans;
                unum >>= 4;
            }

            return ans;
        }

        public char ToHexChar(uint num)
        {
            if (num <= 9)
            {
                return (char)('0' + num);
            }

            return (char)('a' + num - 10);
        }
    }
}