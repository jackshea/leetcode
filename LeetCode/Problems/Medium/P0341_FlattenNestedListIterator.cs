using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 扁平化嵌套列表迭代器
    /// https://leetcode-cn.com/problems/flatten-nested-list-iterator/
    public class NestedIterator
    {
        private Stack<NestedInteger> stack = new Stack<NestedInteger>();

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            for (int i = nestedList.Count - 1; i >= 0; i--)
            {
                stack.Push(nestedList[i]);
            }
        }

        public bool HasNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }

            var current = stack.Peek();
            while (!current.IsInteger())
            {
                stack.Pop();
                var list = current.GetList();
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    stack.Push(list[i]);
                }
                if (stack.Count == 0)
                {
                    return false;
                }

                current = stack.Peek();
            }

            return true;
        }

        public int Next()
        {
            return stack.Pop().GetInteger();
        }
    }

    public interface NestedInteger
    {
        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }
}