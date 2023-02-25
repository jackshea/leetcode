namespace LeetCode.Problems.Easy;

/// 反转字符串
public class P0344_ReverseString
{
    public void ReverseString(char[] s)
    {
        var i = 0;
        var j = s.Length - 1;
        while (i < j)
        {
            var temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            i++;
            j--;
        }
    }
}