namespace LeetCode.Problems.Medium;

/// 优美的排列 II
/// https://leetcode-cn.com/problems/beautiful-arrangement-ii/
public class P0667_BeautifulArrangementII
{
    public int[] ConstructArray(int n, int k)
    {
        var ans = new int[n];
        int a = 1, b = k + 1;
        for (var i = 0; i < k + 1; i++)
            if (i % 2 == 0)
            {
                ans[i] = a;
                a++;
            }
            else
            {
                ans[i] = b;
                b--;
            }

        for (var i = k + 1; i < n; i++) ans[i] = i + 1;

        return ans;
    }
}