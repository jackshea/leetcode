namespace LeetCode.Problems.Easy;

/// 可被三整除的偶数的平均值
/// https://leetcode.cn/problems/average-value-of-even-numbers-that-are-divisible-by-three/
public class P2455_AverageValueOfEvenNumbersThatAreDivisibleByThree
{
    public int AverageValue(int[] nums)
    {
        int sum = 0;
        int n = 0;
        foreach (var num in nums)
        {
            if (num % 6 == 0)
            {
                sum += num;
                n++;
            }
        }

        return n == 0 ? 0 : sum / n;
    }
}