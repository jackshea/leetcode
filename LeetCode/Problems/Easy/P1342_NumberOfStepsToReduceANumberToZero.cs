namespace LeetCode.Problems.Easy;

/// 将数字变成 0 的操作次数
/// https://leetcode-cn.com/problems/number-of-steps-to-reduce-a-number-to-zero/
public class P1342_NumberOfStepsToReduceANumberToZero
{
    public int NumberOfSteps(int num)
    {
        var ans = 0;
        while (num != 0)
        {
            ans += num % 2 == 0 ? 1 : 2;
            num >>= 1;
        }

        return ans > 0 ? ans - 1 : ans;
    }
}