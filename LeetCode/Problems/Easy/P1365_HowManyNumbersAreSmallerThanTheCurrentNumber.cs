namespace LeetCode.Problems.Easy;

/// 有多少小于当前数字的数字
/// https://leetcode-cn.com/problems/how-many-numbers-are-smaller-than-the-current-number/
public class P1365_HowManyNumbersAreSmallerThanTheCurrentNumber
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var ans = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            for (var j = 0; j < nums.Length; j++)
            {
                if (i == j) continue;

                if (num < nums[j]) ans[j]++;
            }
        }

        return ans;
    }
}