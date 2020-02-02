namespace LeetCode.Problems.Easy
{
    /// 字符串的最大公因子
    /// https://leetcode-cn.com/problems/greatest-common-divisor-of-strings/
    public class P1071_GreatestCommonDivisorOfStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int div = len1 / len2;
            int mod = len1 % len2;
            int i1 = 0;
            for (int i = 0; i < div; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (str1[i1++] != str2[j])
                    {
                        return string.Empty;
                    }
                }
            }

            if (mod == 0)
            {
                return str2;
            }

            return GcdOfStrings(str2, str1.Substring(len2 * div, mod));
        }
    }
}