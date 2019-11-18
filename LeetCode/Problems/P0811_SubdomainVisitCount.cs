using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 子域名访问计数
    /// https://leetcode-cn.com/problems/subdomain-visit-count/
    public class P0811_SubdomainVisitCount
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            foreach (var cpDomain in cpdomains)
            {
                var cp = cpDomain.Split(' ');
                Visit(cp[1], int.Parse(cp[0]));
            }

            var ans = new List<string>();
            foreach (var kvp in dic)
            {
                ans.Add($"{kvp.Value} {kvp.Key}");
            }

            return ans;
        }

        private void Visit(string domain, int visitTimes)
        {
            if (string.IsNullOrEmpty(domain))
            {
                return;
            }

            if (dic.ContainsKey(domain))
            {
                dic[domain] += visitTimes;
            }
            else
            {
                dic[domain] = visitTimes;
            }

            var dotIndex = domain.IndexOf('.');
            if (dotIndex >= 0)
            {
                string parentDomain = domain.Substring(dotIndex + 1);
                Visit(parentDomain, visitTimes);
            }
        }
    }
}