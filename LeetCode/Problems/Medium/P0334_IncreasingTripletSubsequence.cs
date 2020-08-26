namespace LeetCode.Problems.Medium
{
    /// 递增的三元子序列
    /// https://leetcode-cn.com/problems/increasing-triplet-subsequence/
    public class P0334_IncreasingTripletSubsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int a = int.MaxValue, b = int.MaxValue;
            foreach (var num in nums)
            {
                if (num <= a)
                {
                    a = num;
                }
                else if (num <= b)
                {
                    b = num;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}