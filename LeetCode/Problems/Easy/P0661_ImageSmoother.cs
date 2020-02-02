namespace LeetCode.Problems.Easy
{
    /// 图片平滑器
    /// https://leetcode-cn.com/problems/image-smoother/
    public class P0661_ImageSmoother
    {
        public int[][] ImageSmoother(int[][] M)
        {
            int row = M.Length;
            int col = M[0].Length;
            var result = new int[row][];
            for (int i = 0; i < row; i++)
            {
                result[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    int count = 0;
                    int sum = 0;
                    for (int y = i - 1; y <= i + 1; y++)
                    {
                        for (int x = j - 1; x <= j + 1; x++)
                        {
                            if (y >= 0 && y < row && x >= 0 && x < col)
                            {
                                sum += M[y][x];
                                count++;
                            }
                        }
                    }

                    result[i][j] = sum / count;
                }
            }

            return result;
        }
    }
}