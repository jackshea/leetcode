namespace LeetCode.Problems.Medium
{
    /// 整数替换
    /// https://leetcode-cn.com/problems/integer-replacement/
    public class P0397_IntegerReplacement
    {
        public int IntegerReplacement(int n)
        {
            int ans = 0;
            while (n > 1)
            {
                if ((n & 1) == 0)
                {
                    n >>= 1;
                }
                else
                {
                    if (((n + 1) & 0b11) == 0 && n != 3)
                    {
                        n >>= 1;
                        n++;
                        ans++;
                    }
                    else
                    {
                        n--;
                    }
                }

                ans++;
            }

            return ans;
        }
    }
}