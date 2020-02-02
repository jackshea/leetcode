namespace LeetCode.Problems.Easy
{
    /// 加一
    /// https://leetcode-cn.com/problems/plus-one/description/
    public class P0066_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            digits[digits.Length - 1]++;
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] > 9)
                {
                    if (i == 0)
                    {
                        var result = new int[digits.Length + 1];
                        result[0] = 1;
                        return result;
                    }
                    else
                    {
                        digits[i] = 0;
                        digits[i - 1]++;
                    }
                }
                else
                {
                    return digits;
                }

            }

            return digits;
        }
    }
}