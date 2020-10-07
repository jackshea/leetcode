namespace LeetCode.Problems.Easy
{
    /// 重新排列字符串
    /// https://leetcode-cn.com/problems/shuffle-string/
    public class P1528_ShuffleString
    {
        public string RestoreString(string s, int[] indices)
        {
            char[] ans = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                ans[indices[i]] = s[i];
            }
            return new string(ans);
        }
    }
}