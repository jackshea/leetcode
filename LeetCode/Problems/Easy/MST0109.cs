namespace LeetCode.Problems.Easy
{
    /// 字符串轮转
    /// https://leetcode-cn.com/problems/string-rotation-lcci/
    public class MST0109
    {
        public bool IsFlipedString(string s1, string s2)
        {
            return s1.Length == s2.Length && (s1 + s1).Contains(s2);
        }
    }
}