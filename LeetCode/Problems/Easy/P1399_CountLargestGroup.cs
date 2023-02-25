using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 统计最大组的数目
/// https://leetcode-cn.com/problems/count-largest-group/
public class P1399_CountLargestGroup
{
    public int CountLargestGroup(int n)
    {
        var dic = new Dictionary<int, int>();
        for (var i = 1; i <= n; i++)
        {
            var digitSum = DigitSum(i);
            dic.TryGetValue(digitSum, out var count);
            dic[digitSum] = count + 1;
        }

        int max = 0, maxCount = 0;
        foreach (var kvp in dic)
            if (kvp.Value > max)
            {
                max = kvp.Value;
                maxCount = 1;
            }
            else if (kvp.Value == max)
            {
                maxCount++;
            }

        return maxCount;
    }

    private int DigitSum(int num)
    {
        var sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }
}