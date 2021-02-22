namespace LeetCode.Problems.Medium
{
    /// 设计循环双端队列
    /// https://leetcode-cn.com/problems/design-circular-deque/
    public class MyCircularDeque
    {
        private int[] container;
        private int head; // 队首
        private int tail; // 指向队尾的下一个位置
        private int capacity;

        /** Initialize your data structure here. Set the size of the deque to be k. */
        public MyCircularDeque(int k)
        {
            capacity = k + 1;
            container = new int[capacity];
        }

        /** Adds an item at the front of Deque. Return true if the operation is successful. */
        public bool InsertFront(int value)
        {
            if (IsFull())
            {
                return false;
            }

            head--;
            if (head < 0)
            {
                head = capacity - 1;
            }

            container[head] = value;
            return true;
        }

        /** Adds an item at the rear of Deque. Return true if the operation is successful. */
        public bool InsertLast(int value)
        {
            if (IsFull())
            {
                return false;
            }

            container[tail++] = value;
            if (tail >= capacity)
            {
                tail = 0;
            }

            return true;
        }

        /** Deletes an item from the front of Deque. Return true if the operation is successful. */
        public bool DeleteFront()
        {
            if (IsEmpty())
            {
                return false;
            }

            head++;
            if (head >= capacity)
            {
                head = 0;
            }

            return true;
        }

        /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
        public bool DeleteLast()
        {
            if (IsEmpty())
            {
                return false;
            }

            tail--;
            if (tail < 0)
            {
                tail = capacity - 1;
            }

            return true;
        }

        /** Get the front item from the deque. */
        public int GetFront()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return container[head];
        }

        /** Get the last item from the deque. */
        public int GetRear()
        {
            if (IsEmpty())
            {
                return -1;
            }

            int rear = tail - 1;
            if (rear < 0)
            {
                rear = capacity - 1;
            }
            return container[rear];
        }

        /** Checks whether the circular deque is empty or not. */
        public bool IsEmpty()
        {
            return head == tail;
        }

        /** Checks whether the circular deque is full or not. */
        public bool IsFull()
        {
            return head == 0 && tail == capacity - 1 || tail + 1 == head;
        }
    }
}