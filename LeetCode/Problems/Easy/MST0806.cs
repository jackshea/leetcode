using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 汉诺塔问题
/// https://leetcode-cn.com/problems/hanota-lcci/
public class MST0806
{
    public void Hanota(IList<int> A, IList<int> B, IList<int> C)
    {
        Hanota(A.Count, A, B, C);
    }

    private void Hanota(int n, IList<int> A, IList<int> B, IList<int> C)
    {
        if (n == 1)
        {
            C.Add(A[A.Count - 1]);
            A.RemoveAt(A.Count - 1);
            return;
        }

        Hanota(n - 1, A, C, B);
        Hanota(1, A, B, C);
        Hanota(n - 1, B, A, C);
    }
}