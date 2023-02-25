namespace LeetCode.Problems.Medium;

/// 神奇字符串
/// https://leetcode-cn.com/problems/magical-string/
public class P0481_MagicalString
{
    public int MagicalString(int n)
    {
        if (n <= 0) return 0;
        var line = new int[n];
        var slow = 0;
        var fast = 0;
        var ans = 0;
        var num = 1;
        while (fast < n)
        {
            if (line[slow] == 0) line[slow] = num;

            for (var i = 0; i < line[slow]; i++)
            {
                line[fast++] = num;
                if (num == 1) ans++;
                if (fast >= n) return ans;
            }

            slow++;
            num = num == 1 ? 2 : 1;
        }

        return ans;
    }
}