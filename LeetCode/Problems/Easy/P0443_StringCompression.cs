namespace LeetCode.Problems
{
    /// 压缩字符串
    /// https://leetcode-cn.com/problems/string-compression/
    public class P0443_StringCompression
    {
        public int Compress(char[] chars)
        {
            int charPoint = 0;
            int count = 1;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == chars[i + 1])
                {
                    count++;
                }
                else
                {
                    chars[charPoint++] = chars[i];
                    if (count >= 2)
                    {
                        var charArray = count.ToString().ToCharArray();
                        for (var j = 0; j < charArray.Length; j++)
                        {
                            chars[charPoint++] = charArray[j];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }

            return charPoint;
        }
    }
}