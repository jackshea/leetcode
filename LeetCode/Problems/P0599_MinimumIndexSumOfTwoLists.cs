using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 两个列表的最小索引总和
    /// https://leetcode-cn.com/problems/minimum-index-sum-of-two-lists/
    public class P0599_MinimumIndexSumOfTwoLists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (var i = 0; i < list1.Length; i++)
            {
                dic[list1[i]] = i;
            }

            List<string> result = new List<string>();
            int minIndexSum = Int32.MaxValue;
            for (var i = 0; i < list2.Length; i++)
            {
                if (dic.ContainsKey(list2[i]))
                {
                    int indexSum = dic[list2[i]] + i;
                    if (minIndexSum < indexSum)
                    {
                        continue;
                    }
                    else if (minIndexSum > indexSum)
                    {
                        result.Clear();
                        result.Add(list2[i]);
                        minIndexSum = indexSum;
                    }
                    else
                    {
                        result.Add(list2[i]);
                    }
                }
            }

            return result.ToArray();
        }
    }
}