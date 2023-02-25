namespace LeetCode.Problems.Easy;

/// 字符串的最大公因子
/// https://leetcode-cn.com/problems/greatest-common-divisor-of-strings/
public class P1071_GreatestCommonDivisorOfStrings
{
    public string GcdOfStrings(string str1, string str2)
    {
        var len1 = str1.Length;
        var len2 = str2.Length;
        var div = len1 / len2;
        var mod = len1 % len2;
        var i1 = 0;
        for (var i = 0; i < div; i++)
        for (var j = 0; j < len2; j++)
            if (str1[i1++] != str2[j])
                return string.Empty;

        if (mod == 0) return str2;

        return GcdOfStrings(str2, str1.Substring(len2 * div, mod));
    }
}