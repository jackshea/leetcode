using System;

namespace LeetCode.Problems.Easy;

/// 完美数
/// https://leetcode-cn.com/problems/perfect-number/
public class P0507_PerfectNumber
{
    public bool CheckPerfectNumber(int num)
    {
        if (num == 1) return false;

        var sum = 1;

        var sqrt = Math.Sqrt(num);

        for (var i = 2; i <= sqrt; i++)
        {
            if (i == sqrt)
            {
                sum += i;
                break;
            }

            if (num % i == 0)
            {
                sum += i;
                sum += num / i;
            }
        }

        return sum == num;
    }
}