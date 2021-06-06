namespace LeetCode.Problems.Easy
{
    /// 将所有数字用字符替换
    /// https://leetcode-cn.com/problems/replace-all-digits-with-characters/
    public class P1844_ReplaceAllDigitsWithCharacters
    {
        public string ReplaceDigits(string s)
        {
            var charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    charArray[i] = (char)(charArray[i - 1] + charArray[i] - '0');
                }
            }
            return new string(charArray);
        }
    }
}