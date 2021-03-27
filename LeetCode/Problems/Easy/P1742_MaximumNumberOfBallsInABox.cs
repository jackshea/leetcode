using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 盒子中小球的最大数量
    /// https://leetcode-cn.com/problems/maximum-number-of-balls-in-a-box/
    public class P1742_MaximumNumberOfBallsInABox
    {
        public int CountBalls(int lowLimit, int highLimit)
        {
            Dictionary<int, int> boxes = new Dictionary<int, int>();
            int ans = 0;
            for (int i = lowLimit; i <= highLimit; i++)
            {
                int num = i;
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                boxes.TryGetValue(sum, out var count);
                boxes[sum] = ++count;
                if (ans < count)
                {
                    ans = count;
                }
            }

            return ans;
        }
    }
}