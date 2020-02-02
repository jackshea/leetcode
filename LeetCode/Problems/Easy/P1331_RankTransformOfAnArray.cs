using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy
{
    /// 数组序号转换
    /// https://leetcode-cn.com/problems/rank-transform-of-an-array/
    public class P1331_RankTransformOfAnArray
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return arr;
            }

            List<ValueRank> ranks = new List<ValueRank>();
            for (int i = 0; i < arr.Length; i++)
            {
                ranks.Add(new ValueRank { RawIndex = i, Value = arr[i] });
            }

            ranks.Sort((a, b) => a.Value.CompareTo(b.Value));
            int rank = 1;
            for (int i = 0; i < ranks.Count - 1; i++)
            {
                ranks[i].Rank = rank;
                if (ranks[i].Value != ranks[i + 1].Value)
                {
                    rank++;
                }
            }

            ranks[ranks.Count - 1].Rank = rank;
            ranks.Sort((a, b) => a.RawIndex.CompareTo(b.RawIndex));
            return ranks.Select(p => p.Rank).ToArray();
        }

        public class ValueRank
        {
            public int RawIndex;
            public int Value;
            public int Rank;
        }
    }
}