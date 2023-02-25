using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 至少在两个数组中出现的值
/// https://leetcode.cn/problems/two-out-of-three/
public class P2032_TwoOutOfThree
{
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        var freq = new Dictionary<int, int>();
        foreach (var n in nums1) freq[n] = 0b1;
        foreach (var n in nums2)
        {
            var count = 0;
            freq.TryGetValue(n, out count);
            count |= 0b10;
            freq[n] = count;
        }

        foreach (var n in nums3)
        {
            var count = 0;
            freq.TryGetValue(n, out count);
            count |= 0b100;
            freq[n] = count;
        }

        IList<int> ans = new List<int>();
        foreach (var kvp in freq)
            if (kvp.Value == 0b011 || kvp.Value == 0b101 || kvp.Value == 0b110 || kvp.Value == 0b111)
                ans.Add(kvp.Key);

        return ans;
    }
}