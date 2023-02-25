using System;

namespace LeetCode.Problems.Medium;

/// 爱生气的书店老板
/// https://leetcode-cn.com/problems/grumpy-bookstore-owner/
public class P1052_GrumpyBookstoreOwner
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int X)
    {
        var rawSum = 0;
        for (var i = 0; i < customers.Length; i++) rawSum += grumpy[i] == 0 ? customers[i] : 0;

        var currentSum = 0;
        for (var i = 0; i < X; i++) currentSum += grumpy[i] == 1 ? customers[i] : 0;
        var extraSum = currentSum;

        for (var i = X; i < customers.Length; i++)
        {
            currentSum += grumpy[i] == 1 ? customers[i] : 0;
            currentSum -= grumpy[i - X] == 1 ? customers[i - X] : 0;
            extraSum = Math.Max(extraSum, currentSum);
        }

        return rawSum + extraSum;
    }
}