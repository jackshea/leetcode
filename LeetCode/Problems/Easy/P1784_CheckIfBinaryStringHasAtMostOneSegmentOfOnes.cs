namespace LeetCode.Problems.Easy;

/// 检查二进制字符串字段
/// https://leetcode-cn.com/problems/check-if-binary-string-has-at-most-one-segment-of-ones/
public class P1784_CheckIfBinaryStringHasAtMostOneSegmentOfOnes
{
    public bool CheckOnesSegment(string s)
    {
        for (var i = 0; i < s.Length - 1; i++)
            if (s[i] == '0' && s[i + 1] == '1')
                return false;

        return true;
    }
}