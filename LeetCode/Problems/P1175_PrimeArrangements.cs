namespace LeetCode.Problems
{
    /// 质数排列
    /// https://leetcode-cn.com/problems/prime-arrangements/
    public class P1175_PrimeArrangements
    {
        private const int Mod = 1000000007;

        public int NumPrimeArrangements(int n)
        {
            int primeCount = 0;
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    primeCount++;
                }
            }

            var pc = Factorial(primeCount, 1L);
            return (int)(Factorial(n - primeCount, pc));
        }

        private bool IsPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private long Factorial(int n, long multiply)
        {
            long sum = multiply;
            for (int i = 1; i <= n; i++)
            {
                sum = (sum * i) % Mod;
            }

            return sum;
        }
    }
}