namespace LeetCode.Problems.Easy
{
    /// 哪种连续子字符串更长
    /// https://leetcode-cn.com/problems/longer-contiguous-segments-of-ones-than-zeros/
    public class P1869_LongerContiguousSegmentsOfOnesThanZeros
    {
        public bool CheckZeroOnes(string s)
        {
            int one = 0, zero = 0, maxOne = 0, maxZero = 0;
            foreach (var c in s)
            {
                if (c == '0')
                {
                    zero++;
                    one = 0;
                    if (maxZero < zero)
                    {
                        maxZero = zero;
                    }
                }
                else
                {
                    one++;
                    zero = 0;
                    if (maxOne < one)
                    {
                        maxOne = one;
                    }
                }
            }

            return maxOne > maxZero;
        }
    }
}