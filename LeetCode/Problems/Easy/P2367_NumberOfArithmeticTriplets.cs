using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 算术三元组的数目
/// https://leetcode.cn/problems/number-of-arithmetic-triplets/
public class P2367_NumberOfArithmeticTriplets
{
    public int ArithmeticTriplets(int[] nums, int diff)
    {
        HashSet<int> set=new HashSet<int>();
        foreach (var num in nums)
        {
            set.Add(num);
        }

        int ans = 0;
        foreach (var num in nums)
        {
            if (set.Contains(num+diff) && set.Contains(num+diff*2))
            {
                ans++;
            }
        }

        return ans;
    }
}