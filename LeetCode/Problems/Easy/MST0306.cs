using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 动物收容所
/// https://leetcode-cn.com/problems/animal-shelter-lcci/
public class AnimalShelf
{
    private readonly Queue<int>[] animals = new Queue<int>[2];

    public AnimalShelf()
    {
        animals[0] = new Queue<int>();
        animals[1] = new Queue<int>();
    }

    public void Enqueue(int[] animal)
    {
        animals[animal[1]].Enqueue(animal[0]);
    }

    public int[] DequeueAny()
    {
        if (animals[0].Count == 0 && animals[1].Count == 0) return new[] { -1, -1 };

        var a = int.MaxValue;
        var b = int.MaxValue;

        if (animals[0].Count != 0) a = animals[0].Peek();

        if (animals[1].Count != 0) b = animals[1].Peek();

        var index = a <= b ? 0 : 1;
        return new[] { animals[index].Dequeue(), index };
    }

    public int[] DequeueDog()
    {
        if (animals[1].Count == 0) return new[] { -1, -1 };

        return new[] { animals[1].Dequeue(), 1 };
    }

    public int[] DequeueCat()
    {
        if (animals[0].Count == 0) return new[] { -1, -1 };

        return new[] { animals[0].Dequeue(), 0 };
    }
}