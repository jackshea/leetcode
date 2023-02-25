namespace LeetCode.Problems.Easy;

/// 计数质数
/// https://leetcode-cn.com/problems/count-primes/
public class P0204_CountPrimes
{
    public int CountPrimes(int n)
    {
        var primes = new bool[n];
        for (var i = 2; i < n; i++) primes[i] = true;

        for (var i = 2; i * i < n; i++)
        {
            if (!primes[i]) continue;

            for (var j = i + i; j < n; j += i) primes[j] = false;
        }

        var count = 0;
        foreach (var p in primes)
            if (p)
                count++;

        return count;
    }
}