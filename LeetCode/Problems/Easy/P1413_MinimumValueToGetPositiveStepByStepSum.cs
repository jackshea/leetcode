namespace LeetCode.Problems.Easy;

/// 逐步求和得到正数的最小值
/// https://leetcode-cn.com/problems/minimum-value-to-get-positive-step-by-step-sum/
public class P1413_MinimumValueToGetPositiveStepByStepSum
{
    public int MinStartValue(int[] nums)
    {
        var sum = 0;
        var min = 0;
        foreach (var num in nums)
        {
            sum += num;
            if (sum < min) min = sum;
        }

        return -min + 1;
    }
}