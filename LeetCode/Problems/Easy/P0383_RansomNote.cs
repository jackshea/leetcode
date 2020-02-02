namespace LeetCode.Problems.Easy
{
    /// 赎金信
    /// https://leetcode-cn.com/problems/ransom-note/
    public class P0383_RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] magazineCharCount = new int[26];
            foreach (var c in magazine)
            {
                magazineCharCount[c - 'a']++;
            }

            foreach (var c in ransomNote)
            {
                magazineCharCount[c - 'a']--;
                if (magazineCharCount[c - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}