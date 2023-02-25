using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 独特的电子邮件地址
/// https://leetcode-cn.com/problems/unique-email-addresses/
public class P0929_UniqueEmailAddresses
{
    public int NumUniqueEmails(string[] emails)
    {
        var realEmailSet = new HashSet<string>();
        foreach (var email in emails)
        {
            var split = email.Split('@');
            var localName = split[0];
            var domain = split[1];
            localName = localName.Replace(".", "");
            var indexOf = localName.IndexOf('+');
            if (indexOf > 0) localName = localName.Substring(0, indexOf);

            realEmailSet.Add(localName + "@" + domain);
        }

        return realEmailSet.Count;
    }
}