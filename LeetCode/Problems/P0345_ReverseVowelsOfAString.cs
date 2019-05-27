namespace LeetCode.Problems
{
    /// 反转字符串中的元音字母
    /// https://leetcode-cn.com/problems/reverse-vowels-of-a-string/
    public class P0345_ReverseVowelsOfAString
    {
        public string ReverseVowels(string s)
        {
            char[] chars = s.ToCharArray();
            int i = 0;
            int j = chars.Length - 1;
            while (i < j)
            {
                while (!IsVowel(chars[i]) && i < j)
                {
                    i++;
                }

                while (!IsVowel(chars[j]) && i < j)
                {
                    j--;
                }

                if (i < j)
                {
                    char temp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = temp;
                    i++;
                    j--;
                }
            }
            return new string(chars);
        }

        private bool IsVowel(char c)
        {
            return c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' ||
                   c == 'u' || c == 'U';
        }
    }
}