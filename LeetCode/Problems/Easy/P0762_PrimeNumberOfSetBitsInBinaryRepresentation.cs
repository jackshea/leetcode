﻿namespace LeetCode.Problems.Easy;

/// 二进制表示中质数个计算置位
/// https://leetcode-cn.com/problems/prime-number-of-set-bits-in-binary-representation/
public class P0762_PrimeNumberOfSetBitsInBinaryRepresentation
{
    public int CountPrimeSetBits(int L, int R)
    {
        var ans = 0;
        var primeNumbers = PrimeNumbers();
        for (var i = L; i <= R; i++)
        {
            var bitCount = HammingWeight(i);
            if (primeNumbers[bitCount]) ans++;
        }

        return ans;
    }

    private bool[] PrimeNumbers()
    {
        var primeNumbers = new bool[32];
        for (var i = 2; i < primeNumbers.Length; i++) primeNumbers[i] = true;

        for (var i = 2; i * i < primeNumbers.Length; i++)
        {
            if (!primeNumbers[i]) continue;

            for (var j = i + i; j < primeNumbers.Length; j += i) primeNumbers[j] = false;
        }

        return primeNumbers;
    }

    private int HammingWeight(int n)
    {
        var count = 0;
        while (n != 0)
        {
            if (n % 2 == 1) count++;

            n = n >> 1;
        }

        return count;
    }
}