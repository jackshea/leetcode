using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 独特的电子邮件地址
    /// https://leetcode-cn.com/problems/unique-email-addresses/
    public class P0929_UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> realEmailSet = new HashSet<string>();
            foreach (var email in emails)
            {
                string[] split = email.Split('@');
                string localName = split[0];
                string domain = split[1];
                localName = localName.Replace(".", "");
                var indexOf = localName.IndexOf('+');
                if (indexOf>0)
                {
                    localName = localName.Substring(0, indexOf);
                }

                realEmailSet.Add(localName + "@" + domain);
            }

            return realEmailSet.Count;
        }
    }
}