using System;
using System.Linq;

namespace LeetCode.Contest.Weekly.C230;

/// 通过最少操作次数使数组的和相等
/// https://leetcode-cn.com/contest/weekly-contest-230/problems/equal-sum-arrays-with-minimum-number-of-operations/
public class P5691
{
    public int MinOperations(int[] nums1, int[] nums2)
    {
        var sum1 = nums1.Sum();
        var sum2 = nums2.Sum();
        if (sum1 == sum2) return 0;
        if (sum1 > sum2)
        {
            var temp = sum1;
            sum1 = sum2;
            sum2 = temp;
            var tempArr = nums1;
            nums1 = nums2;
            nums2 = tempArr;
        }

        Array.Sort(nums1);
        Array.Sort(nums2, (a, b) => -a.CompareTo(b));
        int idx1 = 0, idx2 = 0, ans = 0;
        while (sum1 < sum2 && idx1 < nums1.Length && idx2 < nums2.Length)
        {
            var n1 = 6 - nums1[idx1];
            var n2 = nums2[idx2] - 1;
            if (n1 >= n2)
            {
                sum1 += n1;
                idx1++;
            }
            else
            {
                sum2 -= n2;
                idx2++;
            }

            ans++;
        }

        while (sum1 < sum2 && idx1 < nums1.Length)
        {
            sum1 += 6 - nums1[idx1++];
            ans++;
        }

        while (sum1 < sum2 && idx2 < nums2.Length)
        {
            sum2 -= nums2[idx2++] - 1;
            ans++;
        }

        return sum1 >= sum2 ? ans : -1;
    }
}