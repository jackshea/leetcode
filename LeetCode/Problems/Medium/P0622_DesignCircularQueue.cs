namespace LeetCode.Problems.Medium
{
    /// 设计循环队列
    /// https://leetcode-cn.com/problems/design-circular-queue/
    public class MyCircularQueue
    {
        private int[] cq;
        private int head;
        private int tail; // 最后一个元素的下一个索引

        public MyCircularQueue(int k)
        {
            cq = new int[k + 1];
            head = 0;
            tail = 0;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            cq[tail] = value;
            tail = (tail + 1) % cq.Length;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            head = (head + 1) % cq.Length;
            return true;
        }

        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return cq[head];
        }

        public int Rear()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return cq[tail == 0 ? cq.Length - 1 : tail - 1];
        }

        public bool IsEmpty()
        {
            return head == tail;
        }

        public bool IsFull()
        {
            return head == 0 && tail == cq.Length - 1 || tail + 1 == head;
        }
    }
}