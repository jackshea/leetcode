using System;

namespace LeetCode.Problems.Medium;

/// 适龄的朋友
/// https://leetcode-cn.com/problems/friends-of-appropriate-ages/
public class P0825_FriendsOfAppropriateAges
{
    public int NumFriendRequests(int[] ages)
    {
        var ageSegm = new int[121];
        foreach (var age in ages)
            for (var i = age; i < ageSegm.Length; i++)
                ageSegm[i]++;

        var ans = 0;
        foreach (var age in ages)
        {
            var min = age / 2 + 7;
            if (min >= age) continue;
            var max = age >= 100 ? age : Math.Min(age, 100);
            ans += ageSegm[max] - ageSegm[min] - 1;
        }

        return ans;
    }
}