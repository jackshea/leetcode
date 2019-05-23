using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 用栈实现队列
    /// https://leetcode-cn.com/problems/implement-queue-using-stacks/
    public class P0232_ImplementQueueUsingStacks
    {
        private Stack<int> _head = new Stack<int>();
        private Stack<int> _tail = new Stack<int>();

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            _tail.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (_head.Count > 0)
            {
                return _head.Pop();
            }

            while (_tail.Count > 0)
            {
                _head.Push(_tail.Pop());
            }

            return _head.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (_head.Count > 0)
            {
                return _head.Peek();
            }

            while (_tail.Count > 0)
            {
                _head.Push(_tail.Pop());
            }

            return _head.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return _head.Count == 0 && _tail.Count == 0;
        }
    }
}