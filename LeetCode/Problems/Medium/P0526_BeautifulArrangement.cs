namespace LeetCode.Problems.Medium;

/// 优美的排列
/// https://leetcode-cn.com/problems/beautiful-arrangement/
public class P0526_BeautifulArrangement
{
    private int count;
    private bool[] visited;

    public int CountArrangement(int N)
    {
        visited = new bool[N + 1];
        Backtrack(N, 1);
        return count;
    }

    private void Backtrack(int N, int pos)
    {
        if (pos > N)
        {
            count++;
            return;
        }

        for (var i = 1; i <= N; i++)
            if (!visited[i] && (pos % i == 0 || i % pos == 0))
            {
                visited[i] = true;
                Backtrack(N, pos + 1);
                visited[i] = false;
            }
    }
}