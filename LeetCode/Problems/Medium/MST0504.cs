namespace LeetCode.Problems.Medium
{
    /// 下一个数
    /// https://leetcode-cn.com/problems/closed-number-lcci/
    public class MST0504
    {
        public int[] FindClosedNumbers(int num)
        {
            int greater = num + 1, less = num - 1;
            var bitCount = BitCount(num);
            while (greater <= int.MaxValue)
            {
                if (BitCount(greater++) == bitCount)
                {
                    break;
                }
            }

            if (greater < 0)
            {
                greater = -1;
            }
            else
            {
                greater--;
            }

            while (less >= 0)
            {
                if (BitCount(less--) == bitCount)
                {
                    break;
                }
            }

            if (less < 0)
            {
                less = -1;
            }
            else
            {
                less++;
            }

            return new int[] { greater, less };
        }

        private int BitCount(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n &= (n - 1);
                count++;
            }

            return count;
        }
    }
}