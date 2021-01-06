using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 除法求值
    /// https://leetcode-cn.com/problems/evaluate-division/
    public class P0399_EvaluateDivision
    {
        private Dictionary<string, Dictionary<string, double>> map;
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            map = new Dictionary<string, Dictionary<string, double>>();
            for (var i = 0; i < equations.Count; i++)
            {
                var equation = equations[i];
                var from = equation[0];
                var to = equation[1];
                var v = values[i];
                if (!map.TryGetValue(from, out var fromDic))
                {
                    fromDic = new Dictionary<string, double>();
                    map[from] = fromDic;
                }
                fromDic[from] = 1;
                fromDic[to] = v;

                if (!map.TryGetValue(to, out var toDic))
                {
                    toDic = new Dictionary<string, double>();
                    map[to] = toDic;
                }

                toDic[to] = 1;
                toDic[from] = 1 / v;
            }

            double[] ans = new double[queries.Count];
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = DFS(queries[i][0], queries[i][1], new HashSet<string>(), 1);
            }

            return ans;
        }

        private double DFS(string start, string end, HashSet<string> visited, double factor)
        {
            if (visited.Contains(start))
            {
                return -1;
            }

            visited.Add(start);
            if (map.TryGetValue(start, out var next))
            {
                if (next.ContainsKey(end))
                {
                    return factor * map[start][end];
                }

                foreach (var kvp in next)
                {
                    var dfs = DFS(kvp.Key, end, visited, kvp.Value * factor);
                    if (dfs != -1)
                    {
                        return dfs;
                    }
                }
            }

            return -1;
        }
    }
}