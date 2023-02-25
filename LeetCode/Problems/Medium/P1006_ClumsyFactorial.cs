namespace LeetCode.Problems.Medium;

/// 笨阶乘
/// https://leetcode-cn.com/problems/clumsy-factorial/
public class P1006_ClumsyFactorial
{
    public int Clumsy(int N)
    {
        var ans = 0;
        if (N == 1)
            return 1;
        if (N == 2)
            return 2;
        if (N == 3) return 6;

        if (N >= 3) ans = N * (N - 1) / (N - 2);

        var n = (N - 3) % 4;
        if (n == 0)
            ans -= 2;
        else
            ans++;

        if (N >= 8 && n == 1) ans--;

        return ans;
    }
}