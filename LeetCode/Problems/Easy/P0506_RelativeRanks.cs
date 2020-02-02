using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 相对名次
    /// https://leetcode-cn.com/problems/relative-ranks/
    public class P0506_RelativeRanks
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            List<int> rank = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                rank.Add(i);
            }

            rank.Sort((a, b) => nums[b].CompareTo(nums[a]));

            string[] result = new string[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                string rankName = string.Empty;
                switch (i)
                {
                    case 0:
                        rankName = "Gold Medal"; break;
                    case 1:
                        rankName = "Silver Medal"; break;
                    case 2:
                        rankName = "Bronze Medal"; break;
                    default:
                        rankName = (i + 1).ToString(); break;
                }
                result[rank[i]] = rankName;
            }

            return result;
        }
    }
}