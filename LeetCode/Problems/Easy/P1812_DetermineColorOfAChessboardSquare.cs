namespace LeetCode.Problems.Easy;

/// 判断国际象棋棋盘中一个格子的颜色
/// https://leetcode-cn.com/problems/determine-color-of-a-chessboard-square/
public class P1812_DetermineColorOfAChessboardSquare
{
    public bool SquareIsWhite(string coordinates)
    {
        var x = coordinates[0] - 'a' + 1;
        var y = coordinates[1] - '0';
        return (x % 2 != 0) ^ (y % 2 != 0);
    }
}