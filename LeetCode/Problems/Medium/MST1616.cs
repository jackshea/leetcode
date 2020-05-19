namespace LeetCode.Problems.Medium
{
    /// 部分排序
    /// https://leetcode-cn.com/problems/sub-sort-lcci/
    public class MST1616
    {
        public int[] SubSort(int[] array)
        {
            if (array == null || array.Length < 1)
            {
                return new int[] { -1, -1 };
            }

            // 从左往右找右端点
            int max = array[0];
            int right = -1;
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                }
                else
                {
                    right = i;
                }
            }
            if (right == -1)
            {
                return new int[] { -1, -1 };
            }
            // 从右往左找左端点
            int min = array[n - 1];
            int left = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (array[i] <= min)
                {
                    min = array[i];
                }
                else
                {
                    left = i;
                }
            }
            return new int[] { left, right };
        }
    }
}