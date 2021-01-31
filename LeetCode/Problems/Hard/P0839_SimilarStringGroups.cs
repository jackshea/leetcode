using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 相似字符串组
    /// https://leetcode-cn.com/problems/similar-string-groups/
    public class P0839_SimilarStringGroups
    {
        public int NumSimilarGroups(string[] strs)
        {
            FindUnion uf = new FindUnion(strs.Length);
            for (var i = 0; i < strs.Length; i++)
            {
                for (int j = i + 1; j < strs.Length; j++)
                {
                    if (uf.Find(i) != uf.Find(j) && IsSimilar(strs[i], strs[j]))
                    {
                        uf.Union(i, j);
                    }
                }
            }

            return uf.SetCount;
        }

        private bool IsSimilar(string a, string b)
        {
            if (a == b)
            {
                return true;
            }
            List<int> diffIdx = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    diffIdx.Add(i);
                    if (diffIdx.Count > 2)
                    {
                        return false;
                    }
                }
            }
            if (diffIdx.Count != 2)
            {
                return false;
            }

            return a[diffIdx[0]] == b[diffIdx[1]] && a[diffIdx[1]] == b[diffIdx[0]];
        }

        public class FindUnion
        {
            public int SetCount { get; private set; }
            private int[] ancestor;
            public FindUnion(int n)
            {
                ancestor = new int[n];
                SetCount = n;
                for (int i = 0; i < n; i++)
                {
                    ancestor[i] = i;
                }
            }

            public int Find(int x)
            {
                if (ancestor[x] != x)
                {
                    ancestor[x] = Find(ancestor[x]);
                }

                return ancestor[x];
            }

            public bool Union(int a, int b)
            {
                int aa = Find(a);
                int ba = Find(b);
                if (aa == ba)
                {
                    return false;
                }

                ancestor[aa] = ba;
                SetCount--;
                return true;
            }
        }
    }
}