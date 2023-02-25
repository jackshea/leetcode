using System;

namespace LeetCode.Problems.Medium;

/// 数组嵌套
/// https://leetcode-cn.com/problems/array-nesting/
public class P0565_ArrayNesting
{
    public int ArrayNesting(int[] nums)
    {
        var ans = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0) continue;

            var len = 0;
            var jumpIdx = i;
            while (nums[jumpIdx] >= 0)
            {
                var next = nums[jumpIdx];
                nums[jumpIdx] = -1;
                jumpIdx = next;
                len++;
            }

            ans = Math.Max(ans, len);
            if (ans >= nums.Length / 2) break;
        }

        return ans;
    }
}