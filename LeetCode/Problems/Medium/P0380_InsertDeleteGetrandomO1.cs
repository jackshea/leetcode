using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 常数时间插入、删除和获取随机元素
/// https://leetcode-cn.com/problems/insert-delete-getrandom-o1/
public class RandomizedSet
{
    private readonly Dictionary<int, int> dic = new();
    private readonly List<int> keys = new();

    private readonly Random random;

    /**
     * Initialize your data structure here.
     */
    public RandomizedSet()
    {
        random = new Random();
    }

    /**
     * Inserts a value to the set. Returns true if the set did not already contain the specified element.
     */
    public bool Insert(int val)
    {
        if (!dic.ContainsKey(val))
        {
            dic.Add(val, keys.Count);
            keys.Add(val);
            return true;
        }

        return false;
    }

    /**
     * Removes a value from the set. Returns true if the set contained the specified element.
     */
    public bool Remove(int val)
    {
        if (dic.ContainsKey(val))
        {
            keys[dic[val]] = keys[keys.Count - 1];
            dic[keys[keys.Count - 1]] = dic[val];
            keys.RemoveAt(keys.Count - 1);
            dic.Remove(val);
            return true;
        }

        return false;
    }

    /**
     * Get a random element from the set.
     */
    public int GetRandom()
    {
        var randomIndex = random.Next(keys.Count);
        return keys[randomIndex];
    }
}