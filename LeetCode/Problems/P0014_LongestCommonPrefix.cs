namespace LeetCode.Problems
{
    /// 最长公共前缀
    /// https://leetcode-cn.com/problems/longest-common-prefix/description/
    public class P0014_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                if (prefix.Length > strs[i].Length)
                {
                    prefix = prefix.Substring(0, strs[i].Length);
                }

                for (int j = 0; j < prefix.Length; j++)
                {
                    if (strs[i][j] != prefix[j])
                    {
                        prefix = prefix.Substring(0, j);
                        break;
                    }
                }
            }

            return prefix;

        }
    }
}