using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 求众数 II
/// https://leetcode-cn.com/problems/majority-element-ii/
public class P0229_MajorityElementII
{
    public IList<int> MajorityElement(int[] nums)
    {
        IList<int> ans = new List<int>();
        if (nums == null || nums.Length == 0) return ans;

        int cand1 = nums[0], count1 = 0;
        int cand2 = nums[0], count2 = 0;
        foreach (var num in nums)
        {
            if (num == cand1)
            {
                count1++;
                continue;
            }

            if (num == cand2)
            {
                count2++;
                continue;
            }

            if (count1 == 0)
            {
                cand1 = num;
                count1++;
                continue;
            }

            if (count2 == 0)
            {
                cand2 = num;
                count2++;
                continue;
            }

            count1--;
            count2--;
        }

        count1 = 0;
        count2 = 0;
        foreach (var num in nums)
            if (num == cand1)
                count1++;
            else if (num == cand2) count2++;

        if (count1 > nums.Length / 3) ans.Add(cand1);
        if (count2 > nums.Length / 3) ans.Add(cand2);

        return ans;
    }
}