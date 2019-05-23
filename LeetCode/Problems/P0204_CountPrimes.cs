namespace LeetCode.Problems
{
    /// 计数质数
    /// https://leetcode-cn.com/problems/count-primes/
    public class P0204_CountPrimes
    {
        public int CountPrimes(int n)
        {
            bool[] primes = new bool[n];
            for (int i = 2; i < n; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i * i < n; i++)
            {
                if (!primes[i])
                {
                    continue;
                }

                for (int j = i + i; j < n; j += i)
                {
                    primes[j] = false;
                }
            }

            int count = 0;
            foreach (bool p in primes)
            {
                if (p)
                {
                    count++;
                }
            }

            return count;
        }
    }
}