namespace LeetCode.Problems.Easy
{
    /// 找出星型图的中心节点
    /// https://leetcode-cn.com/problems/find-center-of-star-graph/
    public class P1791_FindCenterOfStarGraph
    {
        public int FindCenter(int[][] edges)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (edges[0][i] == edges[1][j])
                    {
                        return edges[0][i];
                    }
                }
            }

            return -1;
        }
    }
}