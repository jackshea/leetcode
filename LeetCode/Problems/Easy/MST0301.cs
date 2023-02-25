namespace LeetCode.Problems.Easy;

/// 三合一
/// https://leetcode-cn.com/problems/three-in-one-lcci/
public class TripleInOne
{
    private readonly int[] stackIndex = { -3, -2, -1 };
    private readonly int[] tripleStack;

    public TripleInOne(int stackSize)
    {
        tripleStack = new int[stackSize * 3];
    }

    public void Push(int stackNum, int value)
    {
        if (stackIndex[stackNum] + 3 >= tripleStack.Length) return;

        stackIndex[stackNum] += 3;
        tripleStack[stackIndex[stackNum]] = value;
    }

    public int Pop(int stackNum)
    {
        if (IsEmpty(stackNum)) return -1;

        var v = tripleStack[stackIndex[stackNum]];
        stackIndex[stackNum] -= 3;
        return v;
    }

    public int Peek(int stackNum)
    {
        if (IsEmpty(stackNum)) return -1;
        return tripleStack[stackIndex[stackNum]];
    }

    public bool IsEmpty(int stackNum)
    {
        return stackIndex[stackNum] < 0;
    }
}