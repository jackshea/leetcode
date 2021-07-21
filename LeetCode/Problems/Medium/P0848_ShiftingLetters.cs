namespace LeetCode.Problems.Medium
{
    /// 字母移位
    /// https://leetcode-cn.com/problems/shifting-letters/
    public class P0848_ShiftingLetters
    {
        public string ShiftingLetters(string s, int[] shifts)
        {
            var chars = s.ToCharArray();
            int shift = 0;
            for (int i = shifts.Length - 1; i >= 0; i--)
            {
                shift = (shift + shifts[i]) % 26;
                chars[i] = (char)((chars[i] - 'a' + shift) % 26 + 'a');
            }
            return new string(chars);
        }
    }
}