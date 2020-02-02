using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 解压缩编码列表
    /// https://leetcode-cn.com/problems/decompress-run-length-encoded-list/
    public class P1313_DecompressRunLengthEncodedList
    {
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> ans = new List<int>();
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    ans.Add(nums[i + 1]);
                }
            }

            return ans.ToArray();
        }
    }
}