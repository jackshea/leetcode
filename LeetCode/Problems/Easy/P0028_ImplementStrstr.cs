namespace LeetCode.Problems.Easy;

/// 实现strStr()
/// https://leetcode-cn.com/problems/implement-strstr/description/
public class P0028_ImplementStrstr
{
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle)) return 0;

        if (haystack.Length < needle.Length) return -1;

        for (var i = 0; i < haystack.Length - needle.Length + 1; i++)
        for (var j = 0; j < needle.Length; j++)
            if (haystack[i + j] == needle[j])
            {
                if (j == needle.Length - 1) return i;
            }
            else
            {
                break;
            }

        return -1;
    }
}