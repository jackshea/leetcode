namespace LeetCode.Problems.Easy
{
    /// 第三大的数
    /// https://leetcode-cn.com/problems/third-maximum-number/
    public class P0414_ThirdMaximumNumber
    {
        public int ThirdMax(int[] nums)
        {
            int a = int.MinValue, b = int.MinValue, c = int.MinValue;
            int flag = 0;
            bool f = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == int.MinValue && f)
                {
                    flag++;
                    f = false;
                }

                if (nums[i] > a)
                {
                    c = b;
                    b = a;
                    a = nums[i];
                    flag++;
                }
                else if (nums[i] > b && nums[i] < a)
                {
                    c = b;
                    b = nums[i];
                    flag++;
                }
                else if (nums[i] > c && nums[i] < b)
                {
                    c = nums[i];
                    flag++;
                }
            }

            return flag >= 3 ? c : a;
        }
    }
}