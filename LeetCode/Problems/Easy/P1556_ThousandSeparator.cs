using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Easy
{
    /// 千位分隔数
    /// https://leetcode-cn.com/problems/thousand-separator/
    public class P1556_ThousandSeparator
    {
        public string ThousandSeparator(int n)
        {
            if (n == 0)
            {
                return "0";
            }
            Stack<char> stack = new Stack<char>();
            int count = 0;
            do
            {
                var c = (char)('0' + n % 10);
                n /= 10;
                stack.Push(c);
                if (++count % 3 == 0 && n != 0)
                {
                    stack.Push('.');
                }
            } while (n != 0);
            return new string(stack.ToArray());
        }
    }
}