namespace LeetCode.Problems.Hard
{
    /// 消除游戏
    /// https://leetcode-cn.com/problems/elimination-game/
    public class P0390_EliminationGame
    {
        /// f(1)=1,b(1)=1
        /// f(n)=n+1-b(n)
        /// f(n)=2*b(n/2)
        public int LastRemaining(int n)
        {
            return n == 1 ? 1 : 2 * (n / 2 + 1 - LastRemaining(n / 2));
        }
    }
}