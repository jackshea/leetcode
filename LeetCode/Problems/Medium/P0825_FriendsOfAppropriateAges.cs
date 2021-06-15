using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 适龄的朋友
    /// https://leetcode-cn.com/problems/friends-of-appropriate-ages/
    public class P0825_FriendsOfAppropriateAges
    {
        public int NumFriendRequests(int[] ages)
        {
            int[] ageSegm = new int[121];
            foreach (var age in ages)
            {
                for (int i = age; i < ageSegm.Length; i++)
                {
                    ageSegm[i]++;
                }
            }

            int ans = 0;
            foreach (var age in ages)
            {
                int min = age / 2 + 7;
                if (min >= age)
                {
                    continue;
                }
                int max = age >= 100 ? age : Math.Min(age, 100);
                ans += ageSegm[max] - ageSegm[min] - 1;
            }

            return ans;
        }
    }
}