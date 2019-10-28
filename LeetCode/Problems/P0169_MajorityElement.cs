namespace LeetCode.Problems
{
    /// 求众数
    /// https://leetcode-cn.com/problems/majority-element/description/
    public class P0169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            int theMajorityElement = nums[0];
            int count = 1;
            for (var i = 1; i < nums.Length; i++)
            {
                var num = nums[i];
                if (count == 0)
                {
                    theMajorityElement = num;
                }

                if (num == theMajorityElement)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return theMajorityElement;
        }
    }
}