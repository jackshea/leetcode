namespace LeetCode.Problems.Easy
{
    /// 解码异或后的数组
    /// https://leetcode-cn.com/problems/decode-xored-array/
    public class P1720_DecodeXoredArray
    {
        public int[] Decode(int[] encoded, int first)
        {
            int[] ans = new int[encoded.Length + 1];
            ans[0] = first;
            for (int i = 1; i < ans.Length; i++)
            {
                ans[i] = encoded[i - 1] ^ ans[i - 1];
            }

            return ans;
        }
    }
}