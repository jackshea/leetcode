using System;

namespace LeetCode.Problems.Medium
{
    public class P5528
    {
        public int[] BestCoordinate(int[][] towers, int radius)
        {
            int rr = radius * radius;
            int max = 0;
            int cur = 0;
            int ansX = 0, ansY = 0;
            for (int i = 0; i <= 50; i++)
            {
                for (int j = 0; j <= 50; j++)
                {
                    cur = 0;
                    foreach (var tower in towers)
                    {
                        int x = tower[0];
                        int y = tower[1];
                        int q = tower[2];
                        var dd = (x - i) * (x - i) + (y - j) * (y - j);
                        if (dd <= rr)
                        {
                            cur += (int)(q / (1 + Math.Sqrt(dd)));
                        }
                    }
                    if (max < cur)
                    {
                        max = cur;
                        ansX = i;
                        ansY = j;
                    }
                }
            }
            return new[] { ansX, ansY };
        }
    }
}