namespace LeetCode.Problems.Easy
{
    /// 重复 N 次的元素
    /// https://leetcode-cn.com/problems/n-repeated-element-in-size-2n-array/
    public class P0961_NRepeatedElementInSize2nArray
    {
        public int RepeatedNTimes(int[] A)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j < A.Length - i; j++)
                {
                    if (A[j] == A[j + i])
                    {
                        return A[j];
                    }
                }
            }

            return -1;
        }
    }
}