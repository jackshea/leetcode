using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Easy
{
    /// Excel表列名称
    /// https://leetcode-cn.com/problems/excel-sheet-column-title/description/
    public class P0168_ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int n)
        {
            Stack<char> stack = new Stack<char>();
            bool isUnits = true;
            while (n > 26)
            {
                if (isUnits)
                {
                    n--;
                }
                stack.Push(ConvertToChar(n % 26));
                n = n / 26;
            }

            stack.Push(ConvertToChar((n - 1) % 26));

            StringBuilder sb = new StringBuilder();
            foreach (var c in stack)
            {
                sb.Append(c);
            }

            return sb.ToString();
        }

        private char ConvertToChar(int n)
        {
            return (char)('A' + n);
        }

        // 一行代码的答案
        //public string ConvertToTitle(int n)
        //{
        //    return n == 0 ? "" : ConvertToTitle(--n / 26) + (char)('A' + (n % 26));
        //}
    }
}