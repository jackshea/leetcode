namespace LeetCode.Problems
{
    /// 排列硬币
    /// https://leetcode-cn.com/problems/arranging-coins/
    public class P0441_ArrangingCoins
    {
        public int ArrangeCoins(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                n -= i;
                count++;
            }

            return count;
        }
    }
}