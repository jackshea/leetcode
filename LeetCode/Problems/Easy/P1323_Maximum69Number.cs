using System;

namespace LeetCode.Problems
{
    /// 6 和 9 组成的最大数字
    /// https://leetcode-cn.com/problems/maximum-69-number/
    public class P1323_Maximum69Number
    {
        public int Maximum69Number(int num)
        {
            var n = num.ToString().ToCharArray();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '6')
                {
                    n[i] = '9';
                    break;
                }
            }

            return Convert.ToInt32(new string(n));
        }
    }
}