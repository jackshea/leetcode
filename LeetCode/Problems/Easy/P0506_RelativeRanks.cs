using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 相对名次
/// https://leetcode-cn.com/problems/relative-ranks/
public class P0506_RelativeRanks
{
    public string[] FindRelativeRanks(int[] nums)
    {
        var rank = new List<int>();
        for (var i = 0; i < nums.Length; i++) rank.Add(i);

        rank.Sort((a, b) => nums[b].CompareTo(nums[a]));

        var result = new string[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            var rankName = string.Empty;
            switch (i)
            {
                case 0:
                    rankName = "Gold Medal";
                    break;
                case 1:
                    rankName = "Silver Medal";
                    break;
                case 2:
                    rankName = "Bronze Medal";
                    break;
                default:
                    rankName = (i + 1).ToString();
                    break;
            }

            result[rank[i]] = rankName;
        }

        return result;
    }
}