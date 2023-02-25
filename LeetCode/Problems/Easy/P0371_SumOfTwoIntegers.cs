namespace LeetCode.Problems.Easy;

/// 两整数之和
/// https://leetcode-cn.com/problems/sum-of-two-integers/submissions/
public class P0371_SumOfTwoIntegers
{
    public int GetSum(int a, int b)
    {
        var sum = a ^ b;
        var carry = (a & b) << 1;
        if (carry == 0) return sum;

        return GetSum(sum, carry);
    }
}