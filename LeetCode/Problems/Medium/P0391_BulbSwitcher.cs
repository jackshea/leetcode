namespace LeetCode.Problems.Medium
{
    /// 灯泡开关
    /// https://leetcode-cn.com/problems/bulb-switcher/
    public class P0391_BulbSwitcher
    {
        public int BulbSwitch(int n)
        {
            int ans = 0;
            for (int i = 1; i * i <= n; i++)
            {
                ans++;
            }

            return ans;
        }
    }
}