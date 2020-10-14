using System.Text;

namespace LeetCode.Problems.Medium
{
    /// 从英文中重建数字
    /// https://leetcode-cn.com/problems/reconstruct-original-digits-from-english/
    public class P0423_ReconstructOriginalDigitsFromEnglish
    {
        public string OriginalDigits(string s)
        {
            int[] cc = new int[26];
            foreach (var c in s)
            {
                cc[c - 'a']++;
            }

            int[] num = new int[10];
            num[0] = cc['z' - 'a'];
            num[2] = cc['w' - 'a'];
            num[4] = cc['u' - 'a'];
            num[6] = cc['x' - 'a'];
            num[8] = cc['g' - 'a'];
            num[1] = cc['o' - 'a'] - num[0] - num[2] - num[4];
            num[3] = cc['t' - 'a'] - num[2] - num[8];
            num[5] = cc['f' - 'a'] - num[4];
            num[7] = cc['s' - 'a'] - num[6];
            num[9] = cc['i' - 'a'] - num[5] - num[6] - num[8];
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < num.Length; i++)
            {
                ans.Append((char)('0' + i), num[i]);
            }

            return ans.ToString();
        }
    }
}