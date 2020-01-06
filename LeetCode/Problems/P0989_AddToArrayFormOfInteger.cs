using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems
{
    /// 数组形式的整数加法
    /// https://leetcode-cn.com/problems/add-to-array-form-of-integer/
    public class P0989_AddToArrayFormOfInteger
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            Stack<int> stackSum = new Stack<int>();
            int carry = 0;
            for (int i = A.Length - 1; K != 0 || carry != 0 || i >= 0; K /= 10, i--)
            {
                int mod = K % 10;
                int a = 0;
                if (i >= 0)
                {
                    a = A[i];
                }
                int sum = a + mod + carry;
                if (sum > 9)
                {
                    carry = 1;
                    sum %= 10;
                }
                else
                {
                    carry = 0;
                }
                stackSum.Push(sum);
            }

            return stackSum.ToList();
        }
    }
}