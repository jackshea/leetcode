namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 66. 构建乘积数组
    /// https://leetcode-cn.com/problems/gou-jian-cheng-ji-shu-zu-lcof/
    public class Offer66
    {
        public int[] ConstructArr(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                return new int[0];
            }
            int[] left = new int[a.Length];
            int product = 1;
            left[0] = 1;
            for (int i = 1; i < a.Length; i++)
            {
                product *= a[i - 1];
                left[i] = product;
            }

            int[] right = new int[a.Length];
            product = 1;
            right[a.Length - 1] = 1;
            for (int i = a.Length - 2; i >= 0; i--)
            {
                product *= a[i + 1];
                right[i] = product;
            }

            int[] ans = new int[a.Length];
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = left[i] * right[i];
            }

            return ans;
        }
    }
}