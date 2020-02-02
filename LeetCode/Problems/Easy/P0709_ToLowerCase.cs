namespace LeetCode.Problems.Easy
{
    /// 转换成小写字母
    /// https://leetcode-cn.com/problems/to-lower-case/
    public class P0709_ToLowerCase
    {
        public string ToLowerCase(string str)
        {
            var charArray = str.ToCharArray();
            for (var i = 0; i < charArray.Length; i++)
            {
                char c = charArray[i];
                if (char.IsUpper(c))
                {
                    charArray[i] = (char)(c + 32);
                }
            }

            return new string(charArray);
        }
    }
}