namespace LeetCode.Problems.Easy
{
    /// 换酒问题
    /// https://leetcode-cn.com/problems/water-bottles/
    public class P1518_WaterBottles
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            return numBottles + (numBottles - 1) / (numExchange - 1);
        }
    }
}