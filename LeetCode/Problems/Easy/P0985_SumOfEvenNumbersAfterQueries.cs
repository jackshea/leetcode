namespace LeetCode.Problems.Easy
{
    /// 查询后的偶数和
    /// https://leetcode-cn.com/problems/sum-of-even-numbers-after-queries/
    public class P0985_SumOfEvenNumbersAfterQueries
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var ans = new int[A.Length];

            int sum = 0;
            foreach (var a in A)
            {
                if (a % 2 == 0)
                {
                    sum += a;
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                var val = queries[i][0];
                var index = queries[i][1];
                var sumi = A[index] + val;
                if (sumi % 2 == 0)
                {
                    // 偶->偶
                    if (A[index] % 2 == 0)
                    {
                        sum += val;
                    }
                    else // 奇->偶
                    {
                        sum += sumi;
                    }
                }
                else
                {
                    // 偶->奇
                    if (A[index] % 2 == 0)
                    {
                        sum -= A[index];
                    }
                    else // 奇->奇
                    {
                        // do nothing
                    }
                }

                A[index] = sumi;
                ans[i] = sum;
            }

            return ans;
        }
    }
}