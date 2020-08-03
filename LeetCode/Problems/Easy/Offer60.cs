namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 60. n个骰子的点数
    /// https://leetcode-cn.com/problems/nge-tou-zi-de-dian-shu-lcof/
    public class Offer60
    {
        public double[] TwoSum(int n)
        {
            double[] pre = new[] { 1.0 / 6, 1.0 / 6, 1.0 / 6, 1.0 / 6, 1.0 / 6, 1.0 / 6 };
            for (int i = 2; i <= n; i++)
            {
                double[] tmp = new double[5 * i + 1];
                for (int j = 0; j < pre.Length; j++)
                    for (int x = 0; x < 6; x++)
                        tmp[j + x] += pre[j] / 6;
                pre = tmp;
            }
            return pre;
        }
    }
}