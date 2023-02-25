namespace LeetCode.Problems.Easy;

/// K 进制表示下的各位数字总和
/// https://leetcode-cn.com/problems/sum-of-digits-in-base-k/
public class P1837_SumOfDigitsInBaseK
{
    public int SumBase(int n, int k)
    {
        var ans = 0;
        while (n > 0)
        {
            ans += n % k;
            n /= k;
        }

        return ans;
    }
}