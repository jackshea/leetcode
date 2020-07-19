namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 03. 数组中重复的数字
    /// https://leetcode-cn.com/problems/shu-zu-zhong-zhong-fu-de-shu-zi-lcof/
    public class Offer03
    {
        public int FindRepeatNumber(int[] nums)
        {
            int[] freq = new int[nums.Length];
            foreach (var num in nums)
            {
                freq[num]++;
                if (freq[num] >= 2)
                {
                    return num;
                }
            }

            return -1;
        }
    }
}