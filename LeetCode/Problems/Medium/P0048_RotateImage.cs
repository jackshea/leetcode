namespace LeetCode.Problems.Medium;

/// 旋转图像
/// https://leetcode-cn.com/problems/rotate-image/
public class P0048_RotateImage
{
    public void Rotate(int[][] matrix)
    {
        var n = matrix.Length;
        var left = 0;
        var right = n - 2;
        var row = 0;

        while (left <= right)
        {
            for (var i = left; i <= right; i++)
            {
                var temp = matrix[row][i];
                matrix[row][i] = matrix[n - 1 - i][row];
                matrix[n - 1 - i][row] = matrix[n - 1 - row][n - 1 - i];
                matrix[n - 1 - row][n - 1 - i] = matrix[i][n - 1 - row];
                matrix[i][n - 1 - row] = temp;
            }

            left++;
            right--;
            row++;
        }
    }
}