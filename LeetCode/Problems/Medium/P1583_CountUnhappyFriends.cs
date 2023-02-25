namespace LeetCode.Problems.Medium;

/// 统计不开心的朋友
/// https://leetcode-cn.com/problems/count-unhappy-friends/
public class P1583_CountUnhappyFriends
{
    public int UnhappyFriends(int n, int[][] preferences, int[][] pairs)
    {
        var order = new int[n, n];
        for (var i = 0; i < n; i++)
        for (var j = 0; j < n - 1; j++)
            order[i, preferences[i][j]] = j;
        var match = new int[n];
        foreach (var pair in pairs)
        {
            int person0 = pair[0], person1 = pair[1];
            match[person0] = person1;
            match[person1] = person0;
        }

        var unhappyCount = 0;
        for (var x = 0; x < n; x++)
        {
            var y = match[x];
            var index = order[x, y];
            for (var i = 0; i < index; i++)
            {
                var u = preferences[x][i];
                var v = match[u];
                if (order[u, x] < order[u, v])
                {
                    unhappyCount++;
                    break;
                }
            }
        }

        return unhappyCount;
    }
}