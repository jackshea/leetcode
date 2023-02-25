namespace LeetCode.Problems.Easy;

/// 将整数转换为两个无零整数的和
/// https://leetcode-cn.com/problems/convert-integer-to-the-sum-of-two-no-zero-integers/
public class P1317_ConvertIntegerToTheSumOfTwoNoZeroIntegers
{
    public int[] GetNoZeroIntegers(int n)
    {
        for (var i = 1; i < n; i++)
        {
            if (i.ToString().Contains("0")) continue;

            var b = n - i;
            if (b.ToString().Contains("0")) continue;

            return new[] { i, b };
        }

        return null;
    }
}