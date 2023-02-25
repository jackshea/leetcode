namespace LeetCode.Problems.Easy;

/// 字符串中的单词数
/// https://leetcode-cn.com/problems/number-of-segments-in-a-string/
public class P0434_NumberOfSegmentsInAString
{
    public int CountSegments(string s)
    {
        var isLastSeparator = true;
        var count = 0;
        foreach (var c in s)
        {
            if (isLastSeparator && c != ' ')
            {
                count++;
                isLastSeparator = false;
            }

            if (c == ' ') isLastSeparator = true;
        }

        return count;
    }
}