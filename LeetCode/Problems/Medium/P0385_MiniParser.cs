using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 迷你语法分析器
/// https://leetcode-cn.com/problems/mini-parser/
public class P0385_MiniParser
{
    private char[] charArray;
    private int index;

    public NestedInteger Deserialize(string s)
    {
        charArray = s.ToCharArray();
        if (s[0] != '[') return new NestedInteger(int.Parse(s));

        return DeserializeImpl();
    }

    public NestedInteger DeserializeImpl()
    {
        var ni = new NestedInteger();
        var num = 0;
        var isNegative = false;
        while (index < charArray.Length - 1)
        {
            index++;
            var c = charArray[index];
            if (c == '[')
            {
                ni.Add(DeserializeImpl());
            }
            else if (c == ']')
            {
                return ni;
            }
            else if (c == ',')
            {
            }
            else if (c == '-')
            {
                isNegative = true;
            }
            else
            {
                num = 10 * num + (c - '0');
                if (!char.IsDigit(charArray[index + 1]))
                {
                    if (isNegative) num = -num;

                    ni.Add(new NestedInteger(num));
                    num = 0;
                    isNegative = false;
                }
            }
        }

        return null;
    }


    // This is the interface that allows for creating nested lists.
    // You should not implement it, or speculate about its implementation
    public class NestedInteger
    {
        // Constructor initializes an empty nested list.
        public NestedInteger()
        {
        }

        // Constructor initializes a single integer.
        public NestedInteger(int value)
        {
        }

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        public bool IsInteger()
        {
            return true;
        }

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        public int GetInteger()
        {
            return 0;
        }

        // Set this NestedInteger to hold a single integer.
        public void SetInteger(int value)
        {
        }

        // Set this NestedInteger to hold a nested list and adds a nested integer to it.
        public void Add(NestedInteger ni)
        {
        }

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        public IList<NestedInteger> GetList()
        {
            return new List<NestedInteger>();
        }
    }
}