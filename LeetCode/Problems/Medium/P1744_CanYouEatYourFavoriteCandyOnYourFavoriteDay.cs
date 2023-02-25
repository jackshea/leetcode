namespace LeetCode.Problems.Medium;

/// 你能在你最喜欢的那天吃到你最喜欢的糖果吗？
/// https://leetcode-cn.com/problems/can-you-eat-your-favorite-candy-on-your-favorite-day/
public class P1744_CanYouEatYourFavoriteCandyOnYourFavoriteDay
{
    public bool[] CanEat(int[] candiesCount, int[][] queries)
    {
        var preSum = new long[candiesCount.Length];
        preSum[0] = candiesCount[0];
        for (var i = 1; i < candiesCount.Length; i++) preSum[i] = preSum[i - 1] + candiesCount[i];

        var ans = new bool[queries.Length];
        for (var i = 0; i < queries.Length; i++)
        {
            var query = queries[i];
            int favoriteType = query[0], favoriteDay = query[1], dailyCap = query[2];

            long x1 = favoriteDay + 1;
            var y1 = x1 * dailyCap;
            var x2 = favoriteType == 0 ? 1 : preSum[favoriteType - 1] + 1;
            var y2 = preSum[favoriteType];

            ans[i] = !(x1 > y2 || y1 < x2);
        }

        return ans;
    }
}