namespace LeetCode.Problems.Easy;

/// 种花问题
/// https://leetcode-cn.com/problems/can-place-flowers/
public class P0605_CanPlaceFlowers
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        for (var i = 0; i < flowerbed.Length; i++)
            if (flowerbed[i] == 0
                && (i == 0 || flowerbed[i - 1] == 0)
                && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;
                n--;
                if (n <= 0) return true;
            }

        return n <= 0;
    }
}