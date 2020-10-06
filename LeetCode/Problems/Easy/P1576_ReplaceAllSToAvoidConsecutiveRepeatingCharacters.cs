namespace LeetCode.Problems.Easy
{
    /// 替换所有的问号
    /// https://leetcode-cn.com/problems/replace-all-s-to-avoid-consecutive-repeating-characters/
    public class P1576_ReplaceAllSToAvoidConsecutiveRepeatingCharacters
    {
        public string ModifyString(string s)
        {
            var cs = s.ToCharArray();
            char pre = '?';
            for (int i = 0; i < cs.Length; i++)
            {
                if (cs[i] == '?')
                {
                    char next = i < cs.Length - 1 ? cs[i + 1] : '?';
                    if (pre != 'a' && next != 'a')
                    {
                        cs[i] = 'a';
                    }
                    else if (pre != 'b' && next != 'b')
                    {
                        cs[i] = 'b';
                    }
                    else
                    {
                        cs[i] = 'c';
                    }
                }

                pre = cs[i];
            }
            return new string(cs);
        }
    }
}