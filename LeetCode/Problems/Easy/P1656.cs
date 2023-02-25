using System.Collections.Generic;

namespace LeetCode.Problems.Easy.P1656;

/// 设计有序流
/// https://leetcode-cn.com/problems/design-an-ordered-stream/
public class OrderedStream
{
    private readonly string[] stringArray;
    private int ptr = 1;

    public OrderedStream(int n)
    {
        stringArray = new string[n + 1];
    }

    public IList<string> Insert(int id, string value)
    {
        stringArray[id] = value;
        IList<string> ans = new List<string>();
        while (ptr < stringArray.Length && stringArray[ptr] != null)
        {
            ans.Add(stringArray[ptr]);
            ptr++;
        }

        return ans;
    }
}