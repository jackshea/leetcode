namespace LeetCode.Problems.Easy
{
    /// 长度为三且各字符不同的子字符串
    /// https://leetcode-cn.com/problems/substrings-of-size-three-with-distinct-characters/
    public class P1876_SubstringsOfSizeThreeWithDistinctCharacters
    {
        public int CountGoodSubstrings(string s)
        {
            int ans = 0;
            if (s.Length <= 2)
            {
                return 0;
            }

            for (int i = 2; i < s.Length; i++)
            {
                if (s[i - 1] == s[i - 2] || s[i] == s[i - 1] || s[i] == s[i - 2])
                {
                    continue;
                }
                else
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}