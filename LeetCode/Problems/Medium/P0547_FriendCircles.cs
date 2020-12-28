namespace LeetCode.Problems.Medium
{
    /// 朋友圈
    /// https://leetcode-cn.com/problems/friend-circles/
    public class P0547_FriendCircles
    {
        private bool[] isVisited;
        public int FindCircleNum(int[][] M)
        {
            int ans = 0;
            isVisited = new bool[M.Length];
            for (int i = 0; i < M.Length; i++)
            {
                if (!isVisited[i])
                {
                    DFS(M, i);
                    ans++;
                }
            }

            return ans;
        }

        private void DFS(int[][] M, int start)
        {
            for (int i = 0; i < M[start].Length; i++)
            {
                if (M[start][i] == 1 && !isVisited[i])
                {
                    isVisited[i] = true;
                    DFS(M, i);
                }
            }
        }
    }
}