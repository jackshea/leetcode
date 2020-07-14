namespace LeetCode.Problems.Easy
{
    /// 数组中两元素的最大乘积
    /// https://leetcode-cn.com/problems/maximum-product-of-two-elements-in-an-array/
    public class P1464_MaximumProductOfTwoElementsInAnArray
    {
        public int MaxProduct(int[] nums)
        {
            int a1 = nums[0];
            int a2 = nums[1];
            if (a1 < a2)
            {
                Swap(ref a1, ref a2);
            }

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] > a2)
                {
                    a2 = nums[i];
                    if (a2 > a1)
                    {
                        Swap(ref a1, ref a2);
                    }
                }
            }

            return (a1 - 1) * (a2 - 1);
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}