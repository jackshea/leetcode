namespace LeetCode.Problems.Easy
{
    /// 不用加号的加法 
    /// https://leetcode-cn.com/problems/add-without-plus-lcci/
    public class MST1701
    {
        public int Add(int a, int b)
        {
            int sum = 0, carry = 0;
            while (b != 0)
            {
                sum = a ^ b;
                carry = (a & b) << 1;
                a = sum;
                b = carry;
            }

            return a;
        }
    }
}