namespace LeetCode.Problems.Easy;

/// 判断矩阵经轮转后是否一致
/// https://leetcode-cn.com/problems/determine-whether-matrix-can-be-obtained-by-rotation/
public class P1886_DetermineWhetherMatrixCanBeObtainedByRotation
{
    public bool FindRotation(int[][] mat, int[][] target)
    {
        bool b0 = true, b1 = true, b2 = true, b3 = true;
        var n = mat.Length;
        for (var i = 0; i < mat.Length; i++)
        for (var j = 0; j < mat[i].Length; j++)
        {
            if (mat[i][j] != target[i][j]) b0 = false;

            if (mat[n - 1 - j][i] != target[i][j]) b1 = false;

            if (mat[j][n - 1 - i] != target[i][j]) b2 = false;

            if (mat[n - 1 - i][n - 1 - j] != target[i][j]) b3 = false;

            if (!(b0 || b1 || b2 || b3)) return false;
        }

        return true;
    }
}