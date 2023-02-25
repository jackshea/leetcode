using System;

namespace LeetCode.Problems.Easy;

/// 猜数字游戏
/// https://leetcode-cn.com/problems/bulls-and-cows/
public class P0299_BullsAndCows
{
    public string GetHint(string secret, string guess)
    {
        var bulls = 0;
        var secretCounts = new int[10];
        var guessCounts = new int[10];
        for (var i = 0; i < secret.Length; i++)
        {
            secretCounts[secret[i] - '0']++;
            guessCounts[guess[i] - '0']++;
            if (secret[i] == guess[i]) bulls++;
        }

        var bullsAndCows = 0;
        for (var i = 0; i < 10; i++) bullsAndCows += Math.Min(secretCounts[i], guessCounts[i]);

        return $"{bulls}A{bullsAndCows - bulls}B";
    }
}