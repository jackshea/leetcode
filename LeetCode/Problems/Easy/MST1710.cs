namespace LeetCode.Problems.Easy
{
    /// 面试题 17.10. 主要元素
    /// https://leetcode-cn.com/problems/find-majority-element-lcci/
    public class MST1710
    {
        public int MajorityElement(int[] nums)
        {
            int count = 1;
            int ans = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                if (count == 0)
                {
                    ans = num;
                    count++;
                    continue;
                }
                if (ans == num)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            if (count > 0)
            {
                int checkCount = 0;
                foreach (var num in nums)
                {
                    if (ans == num)
                    {
                        checkCount++;
                    }
                }

                if (checkCount > nums.Length / 2)
                {
                    return ans;
                }
            }

            return -1;
        }
    }
}