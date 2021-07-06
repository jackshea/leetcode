using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 点菜展示表
    /// https://leetcode-cn.com/problems/display-table-of-food-orders-in-a-restaurant/
    public class P1418_DisplayTableOfFoodOrdersInARestaurant
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            Dictionary<int, Dictionary<string, int>> dic = new Dictionary<int, Dictionary<string, int>>();
            HashSet<string> foodNameSet = new HashSet<string>();
            foreach (var order in orders)
            {
                int table = int.Parse(order[1]);
                string food = order[2];
                if (!dic.TryGetValue(table, out var foods))
                {
                    foods = new Dictionary<string, int>();
                    dic[table] = foods;
                }

                foods.TryGetValue(food, out var count);
                foods[food] = count + 1;
                foodNameSet.Add(food);
            }

            var foodNames = foodNameSet.ToList();
            foodNames.Sort(string.CompareOrdinal);
            IList<IList<string>> ans = new List<IList<string>>();
            List<string> title = new List<string>();
            title.Add("Table");
            title.AddRange(foodNames);
            ans.Add(title);
            List<int> tables = dic.Keys.ToList();
            tables.Sort();
            foreach (var table in tables)
            {
                var row = new List<string>();
                var current = dic[table];
                row.Add(table.ToString());
                foreach (var foodName in foodNames)
                {
                    current.TryGetValue(foodName, out var cnt);
                    row.Add(cnt.ToString());
                }
                ans.Add(row);
            }

            return ans;
        }
    }
}