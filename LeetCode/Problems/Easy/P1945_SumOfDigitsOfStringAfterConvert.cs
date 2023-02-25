namespace LeetCode.Problems.Easy;

/// 字符串转化后的各位数字之和
/// https://leetcode.cn/problems/sum-of-digits-of-string-after-convert/
public class P1945_SumOfDigitsOfStringAfterConvert
{
    public int GetLucky(string s, int k)
    {
        var sum = 0;
        foreach (var c in s) sum += DigitSum(c - 'a' + 1);

        for (var i = 0; i < k - 1; i++) sum = DigitSum(sum);

        return sum;
    }

    public int DigitSum(int number)
    {
        var sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number = number / 10;
        }

        return sum;
    }
}