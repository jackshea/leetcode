namespace LeetCode.Problems.Easy
{
    /// 猜数字大小
    /// https://leetcode-cn.com/problems/guess-number-higher-or-lower/
    public class P0374_GuessNumberHigherOrLower
    {
        public int GuessNumber(int n)
        {
            int left = 1, right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                var cmp = guess(mid);
                if (cmp == 1)
                {
                    left = mid + 1;
                }
                else if (cmp == -1)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return left;
        }

        private int guess(int num)
        {
            return 0;
        }
    }
}