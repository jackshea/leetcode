namespace LeetCode.Problems.Easy;

/// 重复至少 K 次且长度为 M 的模式
/// https://leetcode-cn.com/problems/detect-pattern-of-length-m-repeated-k-or-more-times/
public class P1566_DetectPatternOfLengthMRepeatedKOrMoreTimes
{
    public bool ContainsPattern(int[] arr, int m, int k)
    {
        for (var i = 0; i <= arr.Length - m * k; i++)
        {
            var j = i + m;
            for (; j < i + m * k; j++)
                if (arr[j] != arr[j - m])
                    break;

            if (j == i + m * k) return true;
        }

        return false;
    }
}