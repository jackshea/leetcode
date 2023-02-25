using System;
using System.Linq;

namespace LeetCode.Problems.Medium;

/// 火柴拼正方形
/// https://leetcode-cn.com/problems/matchsticks-to-square/
public class P0473_MatchsticksToSquare
{
    public bool Makesquare(int[] nums)
    {
        if (nums.Length < 4) return false;
        var sum = nums.Sum();
        if (sum == 0 || sum % 4 != 0) return false;

        var sides = new int[4];
        var sideLen = sum / 4;
        Array.Sort(nums, (a, b) => -a.CompareTo(b));
        return Backtracking(nums, sides, 0, sideLen);
    }

    private bool Backtracking(int[] nums, int[] sides, int startIndex, int maxSideLen)
    {
        if (startIndex == nums.Length)
        {
            foreach (var side in sides)
                if (side != maxSideLen)
                    return false;

            return true;
        }

        for (var i = 0; i < 4; i++)
        {
            if (sides[i] + nums[startIndex] > maxSideLen) continue;

            sides[i] += nums[startIndex];
            if (Backtracking(nums, sides, startIndex + 1, maxSideLen)) return true;
            sides[i] -= nums[startIndex];
        }

        return false;
    }
}