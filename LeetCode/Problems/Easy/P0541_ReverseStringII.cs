namespace LeetCode.Problems.Easy;

/// 反转字符串 II
/// https://leetcode-cn.com/problems/reverse-string-ii/
public class P0541_ReverseStringII
{
    public string ReverseStr(string s, int k)
    {
        var charArray = s.ToCharArray();
        for (var i = 0; i < charArray.Length; i++)
        {
            var m = i % (2 * k);
            if (m < k)
            {
                var n = i - m + k - m - 1;
                n = i - m + k - 1 < charArray.Length ? n : charArray.Length - m - 1;
                if (i < n) Swap(ref charArray[i], ref charArray[n]);
            }
        }

        return new string(charArray);
    }

    private void Swap(ref char a, ref char b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
}