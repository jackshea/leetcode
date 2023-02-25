using System;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 17. 打印从1到最大的n位数
/// https://leetcode-cn.com/problems/da-yin-cong-1dao-zui-da-de-nwei-shu-lcof/
public class Offer17
{
    public int[] PrintNumbers(int n)
    {
        var max = (int)Math.Pow(10, n) - 1;
        var ans = new int[max];
        for (var i = 0; i < max; i++) ans[i] = i + 1;

        return ans;
    }
}