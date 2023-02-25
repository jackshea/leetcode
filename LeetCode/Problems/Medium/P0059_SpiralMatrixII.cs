namespace LeetCode.Problems.Medium;

public class P0059_SpiralMatrixII
{
    /// 螺旋矩阵 II
    /// https://leetcode-cn.com/problems/spiral-matrix-ii/
    public int[][] GenerateMatrix(int n)
    {
        int[] dc = { 1, 0, -1, 0 }; // 行变化量
        int[] dr = { 0, 1, 0, -1 }; // 列变化量
        var start = 0;
        var len = n - 1;
        var v = 1;
        var ans = new int[n][];
        var r = 0;
        var c = 0;
        for (var i = 0; i < n; i++) ans[i] = new int[n];
        while (len > 0)
        {
            for (var i = 0; i < dc.Length; i++)
            for (var j = 0; j < len; j++)
            {
                ans[r][c] = v;
                v++;
                r += dr[i];
                c += dc[i];
            }

            start++;
            len -= 2;
            r = start;
            c = start;
        }

        if (len == 0) ans[r][c] = v;

        return ans;
    }
}