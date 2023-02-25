namespace LeetCode.Problems.Easy;

/// 图像渲染
/// https://leetcode-cn.com/problems/flood-fill/
public class P0733_FloodFill
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        if (image[sr][sc] != newColor) Dfs(image, sr, sc, image[sr][sc], newColor);

        return image;
    }

    private void Dfs(int[][] image, int r, int c, int color, int newColor)
    {
        if (image[r][c] != color) return;

        image[r][c] = newColor;

        if (r > 0) Dfs(image, r - 1, c, color, newColor);

        if (r < image.Length - 1) Dfs(image, r + 1, c, color, newColor);

        if (c > 0) Dfs(image, r, c - 1, color, newColor);

        if (c < image[0].Length - 1) Dfs(image, r, c + 1, color, newColor);
    }
}