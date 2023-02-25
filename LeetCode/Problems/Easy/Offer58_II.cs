namespace LeetCode.Problems.Easy;

/// 剑指 Offer 58 - II. 左旋转字符串
/// https://leetcode-cn.com/problems/zuo-xuan-zhuan-zi-fu-chuan-lcof/
public class Offer58_II
{
    public string ReverseLeftWords(string s, int n)
    {
        var left = s.Substring(0, n);
        var right = s.Substring(n, s.Length - n);
        return right + left;
    }
}