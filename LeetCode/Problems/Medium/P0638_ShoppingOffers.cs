using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 大礼包
    /// https://leetcode-cn.com/problems/shopping-offers/
    public class P0638_ShoppingOffers
    {
        public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
        {
            return DFS(price, special, needs);
        }

        public int DFS(IList<int> price, IList<IList<int>> special, IList<int> needs)
        {
            int totalCost = 0;
            for (int i = 0; i < needs.Count; i++)
            {
                totalCost += price[i] * needs[i];
            }

            foreach (var pack in special)
            {
                var currentNeeds = new List<int>(needs);
                bool check = true;
                for (var i = 0; i < currentNeeds.Count; i++)
                {
                    if (pack[i] > currentNeeds[i])
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    for (var i = 0; i < currentNeeds.Count; i++)
                    {
                        currentNeeds[i] -= pack[i];
                    }

                    totalCost = Math.Min(totalCost, pack[currentNeeds.Count] + DFS(price, special, currentNeeds));
                }
            }

            return totalCost;
        }
    }
}