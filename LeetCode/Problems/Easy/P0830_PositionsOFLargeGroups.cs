using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 较大分组的位置
    /// https://leetcode-cn.com/problems/positions-of-large-groups/
    public class P0830_PositionsOFLargeGroups
    {
        public IList<IList<int>> LargeGroupPositions(string S)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            int lastIndex = 0;
            for (var i = 0; i < S.Length; i++)
            {
                if (i == S.Length - 1 || S[i] != S[i + 1])
                {
                    if (i - lastIndex >= 2)
                    {
                        ans.Add(new List<int> { lastIndex, i });
                    }

                    lastIndex = i + 1;
                }
            }

            return ans;
        }
    }
}