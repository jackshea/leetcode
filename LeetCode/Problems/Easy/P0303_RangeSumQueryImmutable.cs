namespace LeetCode.Problems.Easy;

/// 区域和检索 - 数组不可变
/// https://leetcode-cn.com/problems/range-sum-query-immutable/
public class NumArray
{
    private readonly int[] sumArray;

    public NumArray(int[] nums)
    {
        sumArray = new int[nums.Length];
        var sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            sumArray[i] = sum;
        }
    }

    public int SumRange(int i, int j)
    {
        return i > 0 ? sumArray[j] - sumArray[i - 1] : sumArray[j];
    }
}