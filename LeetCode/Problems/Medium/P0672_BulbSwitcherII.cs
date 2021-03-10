namespace LeetCode.Problems.Medium
{
    /// 灯泡开关 Ⅱ
    /// https://leetcode-cn.com/problems/bulb-switcher-ii/
    public class P0672_BulbSwitcherII
    {
        public int FlipLights(int n, int m)
        {
            if (n == 0)
            {
                return 0;
            }

            if (m == 0)
            {
                return 1;
            }

            if (n == 1)
            {
                return 2;
            }

            if (n == 2)
            {
                return m == 1 ? 3 : 4;
            }

            if (m == 1)
            {
                return 4;
            }

            if (m == 2)
            {
                return 7;
            }

            return 8;
        }
    }
}