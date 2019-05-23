using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class P0217_ContainsDuplicate
    {
        /// 存在重复元素
        /// https://leetcode-cn.com/problems/contains-duplicate/submissions/
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> exists = new HashSet<int>();
            foreach (var num in nums)
            {
                if (exists.Contains(num))
                {
                    return true;
                }

                exists.Add(num);
            }

            return false;
        }
    }
}