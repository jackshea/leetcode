namespace LeetCode.Problems.Medium;

/// 香槟塔
/// https://leetcode-cn.com/problems/champagne-tower/
public class P0799_ChampagneTower
{
    public double ChampagneTower(int poured, int query_row, int query_glass)
    {
        var bottomRow = new double[101];
        bottomRow[0] = poured;
        for (var i = 1; i <= query_row; i++)
        {
            for (var j = 0; j <= i; j++) bottomRow[j] = bottomRow[j] > 1 ? bottomRow[j] - 1 : 0;
            for (var j = i; j > 0; j--) bottomRow[j] = (bottomRow[j] + bottomRow[j - 1]) / 2.0;

            bottomRow[0] = bottomRow[0] / 2.0;
        }

        return bottomRow[query_glass] >= 1 ? 1 : bottomRow[query_glass];
    }
}