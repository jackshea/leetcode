using System;

namespace LeetCode.Problems.Medium;

/// 无矛盾的最佳球队
/// https://leetcode.cn/problems/best-team-with-no-conflicts/
public class P1626_BestTeamWithNoConflicts
{
    public int BestTeamScore(int[] scores, int[] ages)
    {
        int n = scores.Length;
        Player[] playerList = new Player[n];
        for (int i = 0; i < n; i++)
        {
            playerList[i] = new Player { score = scores[i], age = ages[i] };
        }
        Array.Sort(playerList, (a, b) =>
        {
            if (a.age != b.age)
            {
                return a.age.CompareTo(b.age);
            }
            return a.score.CompareTo(b.score);
        });

        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
        {
            dp[i] = playerList[i].score;
            for (int j = 0; j < i; j++)
            {
                if (playerList[i].score >= playerList[j].score || playerList[i].age == playerList[j].age)
                {
                    dp[i] = Math.Max(dp[i], dp[j] + playerList[i].score);
                }
            }
        }

        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            ans = Math.Max(ans, dp[i]);
        }

        return ans;
    }

    public class Player
    {
        public int score;
        public int age;
    }
}