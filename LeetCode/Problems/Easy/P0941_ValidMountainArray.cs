using System;

namespace LeetCode.Problems.Easy
{
    /// 有效的山脉数组
    /// https://leetcode-cn.com/problems/valid-mountain-array/
    public class P0941_ValidMountainArray
    {
        public bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3)
            {
                return false;
            }

            State currentState = State.Start;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i - 1] == A[i])
                {
                    return false;
                }
                else if (A[i - 1] < A[i])
                {
                    switch (currentState)
                    {
                        case State.Start:
                            currentState = State.Up;
                            break;
                        case State.Up:
                            break;
                        case State.Down:
                            return false;
                    }
                }
                else if (A[i - 1] > A[i])
                {
                    switch (currentState)
                    {
                        case State.Start:
                            return false;
                        case State.Up:
                            currentState = State.Down;
                            break;
                        case State.Down:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            return currentState == State.Down;
        }

        public enum State
        {
            Start,
            Up,
            Down
        }
    }
}