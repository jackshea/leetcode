namespace LeetCode.Problems.Medium;

/// 灯泡开关
/// https://leetcode-cn.com/problems/bulb-switcher/
public class P0391_BulbSwitcher
{
    public int BulbSwitch(int n)
    {
        var ans = 0;
        for (var i = 1; i * i <= n; i++) ans++;

        return ans;
    }
}