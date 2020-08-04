namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 65. 不用加减乘除做加法
    /// https://leetcode-cn.com/problems/bu-yong-jia-jian-cheng-chu-zuo-jia-fa-lcof/
    public class Offer65
    {
        public int Add(int a, int b)
        {
            int c = a ^ b;
            int carry = (a & b) << 1;
            return carry != 0 ? Add(c, carry) : c;
        }
    }
}