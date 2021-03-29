using System;

namespace LeetCode.Problems.Medium
{
    /// 行星碰撞
    /// https://leetcode-cn.com/problems/asteroid-collision/
    public class P0735_AsteroidCollision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            int len = 0;
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] > 0)
                {
                    asteroids[len++] = asteroids[i];
                }
                else
                {
                    while (len > 0 && asteroids[len - 1] > 0 && asteroids[len - 1] + asteroids[i] < 0)
                    {
                        len--;
                    }

                    if (len > 0 && asteroids[len - 1] + asteroids[i] == 0)
                    {
                        len--;
                    }
                    else if (len <= 0 || asteroids[len - 1] < 0)
                    {
                        asteroids[len++] = asteroids[i];
                    }
                }
            }
            int[] ans = new int[len];
            Array.Copy(asteroids, ans, len);
            return ans;
        }
    }
}