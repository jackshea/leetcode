namespace LeetCode.Problems.Easy
{
    /// 合并排序的数组
    /// https://leetcode-cn.com/problems/group-anagrams-lcci/
    public class MST1001
    {
        public void Merge(int[] A, int m, int[] B, int n)
        {
            m--;
            n--;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (n < 0 || (m >= 0 && A[m] > B[n]))
                {
                    A[i] = A[m--];
                    continue;
                }
                A[i] = B[n--];
            }
        }
    }
}