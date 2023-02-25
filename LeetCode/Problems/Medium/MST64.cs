namespace LeetCode.Problems.Medium;

/// 面试题64. 求1+2+…+n
/// https://leetcode-cn.com/problems/qiu-12n-lcof/
public class MST64
{
    public int SumNums(int n)
    {
        var sum = n;
        var flag = n > 0 && (sum += SumNums(n - 1)) > 0;
        return sum;
    }
}