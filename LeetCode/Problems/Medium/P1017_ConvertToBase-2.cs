using System;
using System.Text;

namespace LeetCode.Problems.Medium;

public class P1017_ConvertToBase_2
{
    public string BaseNeg2(int n)
    {
        StringBuilder ans = new StringBuilder();
        while (n != 0)
        {
            int remain = n % -2;
            ans.Append(Math.Abs(remain).ToString());
            n = remain < 0 ? n / -2 + 1 : n / -2;
        }
        if (ans.Length == 0)
        {
            return "0";
        }

        var charArray = ans.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}