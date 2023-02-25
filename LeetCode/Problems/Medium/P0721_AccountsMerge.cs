using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium;

/// 账户合并
/// https://leetcode-cn.com/problems/accounts-merge/
public class P0721_AccountsMerge
{
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        var email2Index = new Dictionary<string, int>();
        var email2Name = new Dictionary<string, string>();
        var emailIndex = 0;
        foreach (var account in accounts)
        {
            var name = account[0];
            for (var j = 1; j < account.Count; j++)
            {
                var email = account[j];
                if (!email2Index.ContainsKey(email))
                {
                    email2Index[email] = emailIndex;
                    email2Name[email] = name;
                    emailIndex++;
                }
            }
        }

        var unionFind = new UnionFind(emailIndex);
        foreach (var account in accounts)
        {
            var firstIndex = email2Index[account[1]];
            for (var j = 2; j < account.Count; j++) unionFind.Union(firstIndex, email2Index[account[j]]);
        }

        var index2Emails = new Dictionary<int, List<string>>();
        foreach (var kvp in email2Index)
        {
            var index = unionFind.Find(kvp.Value);
            if (!index2Emails.TryGetValue(index, out var emails))
            {
                emails = new List<string>();
                index2Emails[index] = emails;
            }

            emails.Add(kvp.Key);
        }

        IList<IList<string>> ans = new List<IList<string>>();
        foreach (var kvp in index2Emails)
        {
            var row = new List<string> { email2Name[kvp.Value[0]] };
            var emails = kvp.Value.ToList();
            emails.Sort((a, b) => string.Compare(a, b, StringComparison.Ordinal));
            row.AddRange(emails);
            ans.Add(row);
        }

        return ans;
    }

    public class UnionFind
    {
        private readonly int[] ancestor;

        public UnionFind(int n)
        {
            ancestor = new int[n];
            for (var i = 0; i < n; i++) ancestor[i] = i;
        }

        public int Find(int x)
        {
            if (x != ancestor[x]) ancestor[x] = Find(ancestor[x]);

            return ancestor[x];
        }

        public void Union(int a, int b)
        {
            ancestor[Find(a)] = Find(b);
        }
    }
}