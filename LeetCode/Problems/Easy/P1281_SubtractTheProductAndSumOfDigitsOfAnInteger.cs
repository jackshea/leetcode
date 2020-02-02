namespace LeetCode.Problems.Easy
{
    /// 整数的各位积和之差
    /// https://leetcode-cn.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
    public class P1281_SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        public int SubtractProductAndSum(int n)
        {
            int sum = 0;
            int product = 1;
            while (n > 0)
            {
                var mod = n % 10;
                sum += mod;
                product *= mod;
                n /= 10;
            }

            return product - sum;
        }
    }
}