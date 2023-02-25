namespace LeetCode.Problems.Medium;

/// 不同的二叉搜索树
/// https://leetcode-cn.com/problems/unique-binary-search-trees/
public class P0096_UniqueBinarySearchTrees
{
    private int[] cache;

    public int NumTrees(int n)
    {
        if (n <= 0) return 0;

        if (cache == null) cache = new int[n + 1];

        if (cache[n] != 0) return cache[n];

        var ans = 0;
        for (var i = 0; i < n; i++)
        {
            var left = NumTrees(i);
            var right = NumTrees(n - 1 - i);
            var p = left * right;
            p = p == 0 ? left + right : p;
            if (p == 0) p = 1;

            ans += p;
        }

        cache[n] = ans;
        return ans;
    }
}