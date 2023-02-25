using System;

namespace LeetCode.Problems.Easy;

/// 两个数组间的距离值
/// https://leetcode-cn.com/problems/find-the-distance-value-between-two-arrays/
public class P1385_FindTheDistanceValueBetweenTwoArrays
{
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        var ans = 0;
        foreach (var a1 in arr1)
        {
            var check = true;
            foreach (var a2 in arr2)
                if (Math.Abs(a1 - a2) <= d)
                {
                    check = false;
                    break;
                }

            if (check) ans++;
        }

        return ans;
    }
}