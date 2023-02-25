namespace LeetCode.Problems.Easy;

/// 商品折扣后的最终价格
/// https://leetcode-cn.com/problems/final-prices-with-a-special-discount-in-a-shop/
public class P1475_FinalPricesWithASpecialDiscountInAShop
{
    public int[] FinalPrices(int[] prices)
    {
        for (var i = 0; i < prices.Length; i++)
        for (var j = i + 1; j < prices.Length; j++)
            if (prices[i] >= prices[j])
            {
                prices[i] -= prices[j];
                break;
            }

        return prices;
    }
}