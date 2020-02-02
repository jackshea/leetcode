namespace LeetCode.Problems
{
    /// 按奇偶排序数组 II
    /// https://leetcode-cn.com/problems/sort-array-by-parity-ii/
    public class P0922_SortArrayByParityII
    {
        public int[] SortArrayByParityII(int[] A)
        {
            int evenIndex = 0;
            int oddIndex = 1;
            while (evenIndex < A.Length && oddIndex < A.Length)
            {
                if (A[evenIndex] % 2 == 0)
                {
                    evenIndex += 2;
                    continue;
                }

                if (A[oddIndex] % 2 != 0)
                {
                    oddIndex += 2;
                    continue;
                }

                int temp = A[evenIndex];
                A[evenIndex] = A[oddIndex];
                A[oddIndex] = temp;
                evenIndex += 2;
                oddIndex += 2;
            }

            return A;
        }
    }
}