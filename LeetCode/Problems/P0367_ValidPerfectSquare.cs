namespace LeetCode.Problems
{
    /// 有效的完全平方数
    /// https://leetcode-cn.com/problems/valid-perfect-square/
    public class P0367_ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            long left = 1;
            long right = num;
            while (left <= right)
            {
                long mid = left + (right - left) / 2;

                long sqr = mid * mid;
                if (sqr < num)
                {
                    left = mid + 1;
                }
                else if (sqr > num)
                {
                    right = mid - 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}