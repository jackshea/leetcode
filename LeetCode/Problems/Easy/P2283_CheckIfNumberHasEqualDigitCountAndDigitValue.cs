namespace LeetCode.Problems.Easy;

/// 判断一个数的数字计数是否等于数位的值
/// https://leetcode.cn/problems/check-if-number-has-equal-digit-count-and-digit-value/
public class P2283_CheckIfNumberHasEqualDigitCountAndDigitValue
{
    public bool DigitCount(string num)
    {
        var freq = new int[10];
        foreach (var digit in num) freq[digit - '0']++;

        for (var i = 0; i < num.Length; i++)
            if (freq[i] != num[i] - '0')
                return false;

        return true;
    }
}