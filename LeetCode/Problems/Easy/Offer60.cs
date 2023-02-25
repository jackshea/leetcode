namespace LeetCode.Problems.Easy;

/// 剑指 Offer 60. n个骰子的点数
/// https://leetcode-cn.com/problems/nge-tou-zi-de-dian-shu-lcof/
public class Offer60
{
    public double[] TwoSum(int n)
    {
        double[] pre = { 1.0 / 6, 1.0 / 6, 1.0 / 6, 1.0 / 6, 1.0 / 6, 1.0 / 6 };
        for (var i = 2; i <= n; i++)
        {
            var tmp = new double[5 * i + 1];
            for (var j = 0; j < pre.Length; j++)
            for (var x = 0; x < 6; x++)
                tmp[j + x] += pre[j] / 6;
            pre = tmp;
        }

        return pre;
    }
}