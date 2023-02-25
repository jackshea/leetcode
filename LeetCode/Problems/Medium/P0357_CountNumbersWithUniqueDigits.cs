namespace LeetCode.Problems.Medium;

/// 计算各个位数不同的数字个数
/// https://leetcode-cn.com/problems/count-numbers-with-unique-digits/
public class P0357_CountNumbersWithUniqueDigits
{
    public int CountNumbersWithUniqueDigits(int n)
    {
        var factor = 9;
        var product = 9;
        var ans = 1;
        for (var i = 0; i < n; i++)
        {
            ans += product;
            product *= factor--;
        }

        return ans;
    }
}