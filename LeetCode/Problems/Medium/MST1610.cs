using System;

namespace LeetCode.Problems.Medium;

/// 生存人数
/// https://leetcode-cn.com/problems/living-people-lcci/
public class MST1610
{
    public int MaxAliveYear(int[] birth, int[] death)
    {
        Array.Sort(birth);
        Array.Sort(death);
        int j = 0, alive = 0, max = 0, year = 0;
        for (var i = 0; i < birth.Length;)
            if (birth[i] <= death[j])
            {
                alive++;
                if (max < alive)
                {
                    max = alive;
                    year = birth[i];
                }

                i++;
            }
            else
            {
                alive--;
                j++;
            }

        return year;
    }
}