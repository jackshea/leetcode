namespace LeetCode.Problems.Easy
{
    /// 重复的子字符串
    /// https://leetcode-cn.com/problems/repeated-substring-pattern/
    public class P0459_RepeatedSubstringPattern
    {
        public bool RepeatedSubstringPattern(string s)
        {
            int len = s.Length;
            for (int i = 1; i <= len / 2; i++)
            {
                if (len % i != 0)
                {
                    continue;
                }

                string substring = s.Substring(0, i);
                if (IsRepeated(s,substring))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsRepeated(string source, string substring)
        {
            for (int i = 0; i < source.Length; i++)
            {
                var subLen = substring.Length;
                if (source[i] != substring[i % subLen])
                {
                    return false;
                }
            }

            return true;
        }
    }
}