namespace LeetCode.Problems.Easy
{
    /// Nim 游戏
    /// https://leetcode-cn.com/problems/nim-game/
    public class P0292_NimGame
    {
        public bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }
    }
}