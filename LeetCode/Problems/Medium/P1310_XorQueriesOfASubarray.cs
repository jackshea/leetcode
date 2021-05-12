namespace LeetCode.Problems.Medium
{
    /// 子数组异或查询
    /// https://leetcode-cn.com/problems/xor-queries-of-a-subarray/
    public class P1310_XorQueriesOfASubarray
    {
        public int[] XorQueries(int[] arr, int[][] queries)
        {
            int[] xorArray = new int[arr.Length];
            int xor = arr[0];
            for (int i = 0; i < xorArray.Length; i++)
            {
                xor ^= arr[i];
                xorArray[i] = xor;
            }

            int[] ans = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                var query = queries[i];
                ans[i] = arr[query[0]] ^ xorArray[query[0]] ^ xorArray[query[1]];
            }

            return ans;
        }
    }
}