using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 旅行终点站
    /// https://leetcode-cn.com/problems/destination-city/
    public class P1436_DestinationCity
    {
        public string DestCity(IList<IList<string>> paths)
        {
            Dictionary<string, string> nextCity = new Dictionary<string, string>();
            foreach (var path in paths)
            {
                nextCity[path[0]] = path[1];
            }

            string cur = paths[0][0];
            while (nextCity.ContainsKey(cur))
            {
                cur = nextCity[cur];
            }

            return cur;
        }
    }
}