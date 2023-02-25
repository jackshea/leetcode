namespace LeetCode.Problems.Easy;

/// 二进制矩阵中的特殊位置
/// https://leetcode-cn.com/problems/special-positions-in-a-binary-matrix/
public class P1582_SpecialPositionsInABinaryMatrix
{
    public int NumSpecial(int[][] mat)
    {
        if (mat == null || mat.Length == 0) return 0;

        var rowCount = new int[mat.Length];
        var colCount = new int[mat[0].Length];

        for (var i = 0; i < mat.Length; i++)
        for (var j = 0; j < mat[i].Length; j++)
            if (mat[i][j] == 1)
            {
                rowCount[i]++;
                colCount[j]++;
            }

        var ans = 0;
        for (var i = 0; i < mat.Length; i++)
        {
            if (rowCount[i] != 1) continue;

            for (var j = 0; j < mat[i].Length; j++)
                if (colCount[j] == 1 && mat[i][j] == 1)
                {
                    ans++;
                    break;
                }
        }

        return ans;
    }
}