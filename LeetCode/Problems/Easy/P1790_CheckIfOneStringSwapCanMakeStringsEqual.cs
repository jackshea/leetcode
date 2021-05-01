namespace LeetCode.Problems.Easy
{
    /// 仅执行一次字符串交换能否使两个字符串相等
    /// https://leetcode-cn.com/problems/check-if-one-string-swap-can-make-strings-equal/
    public class P1790_CheckIfOneStringSwapCanMakeStringsEqual
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            if (s1 == s2)
            {
                return true;
            }

            int diffIndex1 = -1;
            int diffIndex2 = -1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (diffIndex1 == -1)
                    {
                        diffIndex1 = i;
                    }
                    else if (diffIndex2 == -1)
                    {
                        diffIndex2 = i;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (diffIndex2 == -1)
            {
                return false;
            }

            return s1[diffIndex1] == s2[diffIndex2] && s1[diffIndex2] == s2[diffIndex1];
        }
    }
}