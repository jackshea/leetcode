namespace LeetCode.Problems.Easy;

/// 计算力扣银行的钱
/// https://leetcode-cn.com/problems/calculate-money-in-leetcode-bank/
public class P1716_CalculateMoneyInLeetcodeBank
{
    public int TotalMoney(int n)
    {
        var a = n / 7;
        var sum = 28 * a + 7 * a * (a - 1) / 2;
        for (var i = a + 1; i <= a + n % 7; i++) sum += i;

        return sum;
    }
}