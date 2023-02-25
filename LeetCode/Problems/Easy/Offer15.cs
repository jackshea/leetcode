namespace LeetCode.Problems.Easy;

/// 剑指 Offer 15. 二进制中1的个数
/// https://leetcode-cn.com/problems/er-jin-zhi-zhong-1de-ge-shu-lcof/
public class Offer15
{
    public int HammingWeight(uint n)
    {
        var ans = 0;
        while (n != 0)
        {
            n &= n - 1;
            ans++;
        }

        return ans;
    }
}