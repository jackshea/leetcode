using System.Collections.Generic;

namespace LeetCode.Contest.Weekly.C230
{
    /// 统计匹配检索规则的物品数量
    /// https://leetcode-cn.com/contest/weekly-contest-230/problems/count-items-matching-a-rule/
    public class C5689
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int ans = 0;
            int ruleType = 0;
            foreach (var item in items)
            {
                if (ruleKey == "type")
                {
                    ruleType = 0;
                }
                else if (ruleKey == "color")
                {
                    ruleType = 1;
                }
                if (ruleKey == "name")
                {
                    ruleType = 2;
                }

                if (item[ruleType] == ruleValue)
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}