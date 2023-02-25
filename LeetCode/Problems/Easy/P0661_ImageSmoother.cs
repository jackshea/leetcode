namespace LeetCode.Problems.Easy;

/// 图片平滑器
/// https://leetcode-cn.com/problems/image-smoother/
public class P0661_ImageSmoother
{
    public int[][] ImageSmoother(int[][] M)
    {
        var row = M.Length;
        var col = M[0].Length;
        var result = new int[row][];
        for (var i = 0; i < row; i++)
        {
            result[i] = new int[col];
            for (var j = 0; j < col; j++)
            {
                var count = 0;
                var sum = 0;
                for (var y = i - 1; y <= i + 1; y++)
                for (var x = j - 1; x <= j + 1; x++)
                    if (y >= 0 && y < row && x >= 0 && x < col)
                    {
                        sum += M[y][x];
                        count++;
                    }

                result[i][j] = sum / count;
            }
        }

        return result;
    }
}