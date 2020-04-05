namespace LeetCode.Problems.Medium
{
    /// 颜色分类(三路排序)
    /// https://leetcode-cn.com/problems/sort-colors/
    public class P0075_SortColors
    {
        public void SortColors(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int cur = 1;
            while (cur <= right)
            {
                if (nums[cur] < 1)
                {
                    Swap(nums, left++, cur++);
                }
                else if (nums[cur] > 1)
                {
                    Swap(nums, cur, right--);
                }
                else
                {
                    cur++;
                }
            }
        }

        public void Swap(int[] num, int a, int b)
        {
            int temp = num[a];
            num[a] = num[b];
            num[b] = temp;
        }
    }
}