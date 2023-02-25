using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 好数对的数目
/// https://leetcode-cn.com/problems/number-of-good-pairs/
public class P1512_NumberOfGoodPairs
{
    public int NumIdenticalPairs(int[] nums)
    {
        var ans = 0;
        var dic = new Dictionary<int, int>();
        foreach (var num in nums)
            if (dic.ContainsKey(num))
            {
                ans += dic[num];
                dic[num]++;
            }
            else
            {
                dic[num] = 1;
            }

        return ans;
    }
}