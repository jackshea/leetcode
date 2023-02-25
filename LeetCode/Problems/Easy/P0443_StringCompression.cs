namespace LeetCode.Problems.Easy;

/// 压缩字符串
/// https://leetcode-cn.com/problems/string-compression/
public class P0443_StringCompression
{
    public int Compress(char[] chars)
    {
        if (chars == null || chars.Length == 0) return 0;

        if (chars.Length == 1) return 1;

        var c = chars[0];
        var count = 1;
        var writeIndex = 0;
        var div = 1000;
        for (var i = 1; i < chars.Length; i++)
            if (c == chars[i])
            {
                count++;
            }
            else
            {
                chars[writeIndex++] = c;
                if (count > 1)
                {
                    div = 1000;
                    while (div > count) div /= 10;

                    while (div != 0)
                    {
                        chars[writeIndex++] = (char)(count / div + '0');
                        count %= div;
                        div /= 10;
                    }
                }

                c = chars[i];
                count = 1;
            }

        chars[writeIndex++] = c;
        if (count > 1)
        {
            div = 1000;
            while (div > count) div /= 10;

            while (div != 0)
            {
                chars[writeIndex++] = (char)(count / div + '0');
                count %= div;
                div /= 10;
            }
        }

        return writeIndex;
    }
}