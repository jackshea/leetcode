namespace LeetCode.Problems.Medium;

/// 只有两个键的键盘
/// https://leetcode-cn.com/problems/2-keys-keyboard/
public class P0650_2KeysKeyboard
{
    public int MinSteps(int n)
    {
        var ans = 0;
        for (var i = 2; i <= n; i++)
            while (n % i == 0)
            {
                ans += i;
                n /= i;
            }

        return ans;
    }
}