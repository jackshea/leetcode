using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 出现最频繁的偶数元素
/// https://leetcode.cn/problems/most-frequent-even-element/
public class P2404_MostFrequentEvenElement
{
    public int MostFrequentEven(int[] nums)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                dic.TryGetValue(num, out var cnt);
                dic[num] = cnt + 1;
            }
        }

        if (dic.Count == 0)
        {
            return -1;
        }

        int ans = -1;
        int count = 0;
        foreach (var kvp in dic)
        {
            if (ans == -1 || kvp.Value > count || kvp.Value == count && kvp.Key < ans)
            {
                ans = kvp.Key;
                count = kvp.Value;
            }
        }
        return ans;
    }
}