using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 数组中的K-diff数对
    /// https://leetcode-cn.com/problems/k-diff-pairs-in-an-array/
    public class P0532_KDiffPairsInAnArray
    {
        public int FindPairs(int[] nums, int k)
        {
            if (k < 0)
            {
                return 0;
            }

            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }

            int result = 0;
            foreach (var num in dic.Keys)
            {
                if (k == 0)
                {
                    if (dic[num] > 1)
                    {
                        result++;
                    }
                }
                else if (dic.ContainsKey(num + k))
                {
                    result++;
                }
            }

            return result;
        }
    }
}