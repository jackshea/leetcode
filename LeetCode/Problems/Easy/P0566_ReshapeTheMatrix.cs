namespace LeetCode.Problems.Easy;

/// 重塑矩阵
/// https://leetcode-cn.com/problems/reshape-the-matrix/
public class P0566_ReshapeTheMatrix
{
    public int[][] MatrixReshape(int[][] nums, int r, int c)
    {
        if (nums.Length == 0 || nums.Length * nums[0].Length != r * c) return nums;

        var result = new int[r][];
        for (var i = 0; i < r; i++) result[i] = new int[c];

        var index = 0;
        for (var i = 0; i < nums.Length; i++)
        for (var j = 0; j < nums[0].Length; j++)
        {
            result[index / c][index % c] = nums[i][j];
            index++;
        }

        return result;
    }
}