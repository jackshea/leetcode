﻿namespace LeetCode.Problems.Medium
{
    /// UTF-8 编码验证
    /// https://leetcode-cn.com/problems/utf-8-validation/
    public class P0393_Utf8Validation
    {
        public bool ValidUtf8(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int d = data[i];
                int count = 0;
                if ((d & 0b_1000_0000) == 0)
                {
                    continue;
                }

                if ((d & 0b_1110_0000) == 0b_1100_0000)
                {
                    count = 2;
                }
                else if ((d & 0b_1111_0000) == 0b_1110_0000)
                {
                    count = 3;
                }
                else if ((d & 0b_1111_1000) == 0b_1111_0000)
                {
                    count = 4;
                }
                else
                {
                    return false;
                }

                while (count > 1)
                {
                    i++;
                    if (i >= data.Length || (data[i] & 0b_1100_0000) != 0b_1000_0000)
                    {
                        return false;
                    }
                    count--;
                }
            }

            return true;
        }
    }
}