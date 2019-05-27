namespace LeetCode.Problems
{
    /// 3的幂
    /// https://leetcode-cn.com/problems/power-of-three/
    public class P0326_PowerOfThree
    {
        public bool IsPowerOfThree(int n)
        {
            return n > 0 && 1162261467 % n == 0;
        }
    }
}