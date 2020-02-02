using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 找出给定方程的正整数解
    /// https://leetcode-cn.com/problems/find-positive-integer-solution-for-a-given-equation/
    public class P1237_FindPositiveIntegerSolutionForAGivenEquation
    {
        public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            int y = z;
            for (int x = 1; x <= z && y > 0; x++)
            {
                while (y > 0)
                {
                    int zz = customfunction.f(x, y);
                    if (zz == z)
                    {
                        ans.Add(new List<int>() { x, y });
                        break;
                    }
                    else if (zz > z)
                    {
                        y--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return ans;
        }
    }


    // This is the custom function interface.
    // You should not implement it, or speculate about its implementation
    public interface CustomFunction
    {
        // Returns f(x, y) for any given positive integers x and y.
        // Note that f(x, y) is increasing with respect to both x and y.
        // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
        int f(int x, int y);
    };

}