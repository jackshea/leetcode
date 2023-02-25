using System;

namespace LeetCode.Problems.Hard;

/// 分发糖果
/// https://leetcode-cn.com/problems/candy/
public class P0135_Candy
{
    public int Candy(int[] ratings)
    {
        var candies = new int[ratings.Length];
        for (var i = 0; i < ratings.Length; i++)
            if (i > 0 && ratings[i] > ratings[i - 1])
                candies[i] = candies[i - 1] + 1;
            else
                candies[i] = 1;

        var ans = candies[candies.Length - 1];
        for (var i = ratings.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1]) candies[i] = Math.Max(candies[i], candies[i + 1] + 1);

            ans += candies[i];
        }

        return ans;
    }
}