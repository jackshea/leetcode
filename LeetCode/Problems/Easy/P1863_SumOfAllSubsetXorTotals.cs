namespace LeetCode.Problems.Easy
{
    /// 找出所有子集的异或总和再求和
    /// https://leetcode-cn.com/problems/sum-of-all-subset-xor-totals/
    public class P1863_SumOfAllSubsetXorTotals
    {
        public int SubsetXORSum(int[] nums)
        {
            int ans = 0;
            foreach (var num in nums)
            {
                ans |= num;
            }

            return ans << nums.Length - 1;
        }
    }
}