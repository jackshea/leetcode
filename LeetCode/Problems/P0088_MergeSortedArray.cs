namespace LeetCode.Problems
{
    /// 合并两个有序数组
    /// https://leetcode-cn.com/problems/merge-sorted-array/description/
    public class P0088_MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }
        }
    }
}