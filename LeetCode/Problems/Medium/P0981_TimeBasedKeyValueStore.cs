using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 基于时间的键值存储
    /// https://leetcode-cn.com/problems/time-based-key-value-store/
    public class TimeMap
    {
        private Dictionary<string, List<Tuple<int, string>>> dic;

        /** Initialize your data structure here. */
        public TimeMap()
        {
            dic = new Dictionary<string, List<Tuple<int, string>>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!dic.TryGetValue(key, out var list))
            {
                list = new List<Tuple<int, string>>();
                dic[key] = list;
            }
            list.Add(new Tuple<int, string>(timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            if (!dic.TryGetValue(key, out var list) || list.Count == 0)
            {
                return string.Empty;
            }

            if (list[0].Item1 > timestamp)
            {
                return string.Empty;
            }

            int left = 0, right = list.Count - 1;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (list[mid].Item1 < timestamp)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (left >= list.Count || list[left].Item1 != timestamp)
            {
                return list[left - 1].Item2;
            }

            return list[left].Item2;
        }
    }
}