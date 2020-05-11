namespace LeetCode.Problems.Easy
{
    /// 三步问题
    /// https://leetcode-cn.com/problems/three-steps-problem-lcci/
    public class MST0801
    {
        public int WaysToStep(int n)
        {
            int[] num = { 1, 2, 4 };
            if (n <= 3)
            {
                return num[n - 1];
            }
            int mod = 1000000007;
            for (int i = 3; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < num.Length - 1; j++)
                {
                    sum += num[j];
                    sum %= mod;
                    num[j] = num[j + 1];
                }

                num[num.Length - 1] += sum;
                num[num.Length - 1] %= mod;
            }

            return num[num.Length - 1];
        }
    }
}