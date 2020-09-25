namespace LeetCode.Problems.Medium
{
    /// UTF-8 编码验证
    /// https://leetcode-cn.com/problems/utf-8-validation/
    public class P0393_Utf8Validation
    {
        private int start = 0;
        public bool ValidUtf8(int[] data)
        {
            if (start >= data.Length)
            {
                return true;
            }

            var first = data[start];
            int count = 0;
            if ((first & 0b_1000_0000) == 0)
            {
                count = 0;
            }
            else if ((first & 0b_1110_0000) == 0b_1100_0000)
            {
                count = 2;
            }
            else if ((first & 0b_1111_0000) == 0b_1110_0000)
            {
                count = 3;
            }
            else if ((first & 0b_1111_1000) == 0b_1111_0000)
            {
                count = 4;
            }
            else
            {
                return false;
            }

            start++;
            for (int i = 0; i < count - 1; i++)
            {
                if (start >= data.Length)
                {
                    return false;
                }

                if ((data[start] & 0b_1100_0000) == 0b_1000_0000)
                {
                    start++;
                }
                else
                {
                    return false;
                }
            }

            return ValidUtf8(data);
        }
    }
}