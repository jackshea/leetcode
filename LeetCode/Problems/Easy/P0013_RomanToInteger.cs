namespace LeetCode.Problems.Easy
{
    /// 罗马数字转整数
    /// https://leetcode-cn.com/problems/roman-to-integer/description/
    public class P0013_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currChar = s[i];
                char nextChar = '0';
                if (i + 1 < s.Length)
                {
                    nextChar = s[i + 1];
                }

                if (currChar == 'I' && (nextChar == 'V' || nextChar == 'X'))
                {
                    sum -= GetValue(currChar);
                }
                else if (currChar == 'X' && (nextChar == 'L' || nextChar == 'C'))
                {
                    sum -= GetValue(currChar);
                }
                else if (currChar == 'C' && (nextChar == 'D' || nextChar == 'M'))
                {
                    sum -= GetValue(currChar);
                }
                else
                {
                    sum += GetValue(currChar);
                }
            }

            return sum;
        }

        private int GetValue(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            }

            return 0;
        }
    }
}