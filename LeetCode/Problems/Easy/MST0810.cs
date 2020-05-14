namespace LeetCode.Problems.Easy
{
    /// 颜色填充
    /// https://leetcode-cn.com/problems/color-fill-lcci/
    public class MST0810
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image == null || image.Length == 0)
            {
                return image;
            }

            FloodFill(image, sr, sc, image[sr][sc], newColor);
            return image;
        }

        private void FloodFill(int[][] image, int sr, int sc, int oldColor, int newColor)
        {
            if (oldColor == newColor)
            {
                return;
            }

            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length)
            {
                return;
            }

            if (image[sr][sc] == oldColor)
            {
                image[sr][sc] = newColor;
                FloodFill(image, sr + 1, sc, oldColor, newColor);
                FloodFill(image, sr - 1, sc, oldColor, newColor);
                FloodFill(image, sr, sc + 1, oldColor, newColor);
                FloodFill(image, sr, sc - 1, oldColor, newColor);
            }
        }
    }
}