namespace LeetCode.Problems.Medium
{
    /// 超级次方
    /// https://leetcode-cn.com/problems/super-pow/
    public class P0372_SuperPow
    {
        int mod = 1337;
        public int SuperPow(int a, int[] b)
        {
            int len = b.Length;
            int ans = indexPow(a, b, len);
            return ans;
        }

        //a的k次方对base取模
        private int myPow(int a, int k)
        {
            a %= mod;
            int ans = 1;
            for (int i = 0; i < k; i++)
            {
                ans *= a;
                ans %= mod;
            }
            return ans;
        }
        //加入index判断是否需要终止递归
        private int indexPow(int a, int[] b, int index)
        {
            if (index < 1) return 1;

            int part1 = myPow(a, b[index - 1]);
            index--;
            int part2 = myPow(indexPow(a, b, index), 10);

            return part1 * part2 % mod;
        }
    }
}