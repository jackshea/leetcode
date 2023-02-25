namespace LeetCode.Problems.Easy;

/// 和为零的N个唯一整数
/// https://leetcode-cn.com/problems/find-n-unique-integers-sum-up-to-zero/
public class P1304_FindNUniqueIntegersSumUpToZero
{
    public int[] SumZero(int n)
    {
        var ans = new int[n];
        var sum = 0;
        for (var i = 1; i < n; i++)
        {
            ans[i - 1] = i;
            sum += i;
        }

        ans[n - 1] = -sum;
        return ans;
    }
}