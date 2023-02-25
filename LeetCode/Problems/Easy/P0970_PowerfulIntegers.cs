using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy;

/// 强整数
/// https://leetcode-cn.com/problems/powerful-integers/
public class P0970_PowerfulIntegers
{
    public IList<int> PowerfulIntegers(int x, int y, int bound)
    {
        var ans = new HashSet<int>();
        var xx = 1;
        var yy = 1;
        while (xx < bound)
        {
            yy = 1;
            while (xx + yy <= bound)
            {
                ans.Add(xx + yy);
                yy *= y;
                if (yy == 1) break;
            }

            xx *= x;
            if (xx == 1) break;
        }

        return ans.ToList();
    }
}