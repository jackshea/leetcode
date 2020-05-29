using System;

namespace LeetCode.Problems.Easy
{
    /// 猜数字游戏
    /// https://leetcode-cn.com/problems/bulls-and-cows/
    public class P0299_BullsAndCows
    {
        public string GetHint(string secret, string guess)
        {
            int bulls = 0;
            int[] secretCounts = new int[10];
            int[] guessCounts = new int[10];
            for (int i = 0; i < secret.Length; i++)
            {
                secretCounts[secret[i] - '0']++;
                guessCounts[guess[i] - '0']++;
                if (secret[i] == guess[i])
                {
                    bulls++;
                }
            }

            int bullsAndCows = 0;
            for (int i = 0; i < 10; i++)
            {
                bullsAndCows += Math.Min(secretCounts[i], guessCounts[i]);
            }

            return $"{bulls}A{bullsAndCows - bulls}B";
        }
    }
}