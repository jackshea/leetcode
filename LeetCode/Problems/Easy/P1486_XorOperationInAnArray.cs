namespace LeetCode.Problems.Easy
{
    /// 数组异或操作
    /// https://leetcode-cn.com/problems/xor-operation-in-an-array/
    public class P1486_XorOperationInAnArray
    {
        public int XorOperation(int n, int start)
        {
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans ^= (start + 2 * i);
            }

            return ans;
        }
    }
}