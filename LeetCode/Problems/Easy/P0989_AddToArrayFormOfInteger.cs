using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy;

/// 数组形式的整数加法
/// https://leetcode-cn.com/problems/add-to-array-form-of-integer/
public class P0989_AddToArrayFormOfInteger
{
    public IList<int> AddToArrayForm(int[] A, int K)
    {
        var stackSum = new Stack<int>();
        var carry = 0;
        for (var i = A.Length - 1; K != 0 || carry != 0 || i >= 0; K /= 10, i--)
        {
            var mod = K % 10;
            var a = 0;
            if (i >= 0) a = A[i];
            var sum = a + mod + carry;
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