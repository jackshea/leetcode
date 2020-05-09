namespace LeetCode.Problems.Easy
{
    public class MST0506
    {
        /// 整数转换
        /// https://leetcode-cn.com/problems/convert-integer-lcci/
        public int ConvertInteger(int A, int B)
        {
            int x = A ^ B;
            int count = 0;
            while (x != 0)
            {
                x &= x - 1;
                count++;
            }

            return count;
        }
    }
}