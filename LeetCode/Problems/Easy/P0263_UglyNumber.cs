namespace LeetCode.Problems.Easy
{
    /// 丑数
    /// https://leetcode-cn.com/problems/ugly-number/
    public class P0263_UglyNumber
    {
        public bool IsUgly(int num)
        {
            if (num <= 0)
            {
                return false;
            }

            while (num % 2 == 0)
            {
                num /= 2;
            }

            while (num % 3 == 0)
            {
                num /= 3;
            }

            while (num % 5 == 0)
            {
                num /= 5;
            }

            return num == 1;
        }
    }
}