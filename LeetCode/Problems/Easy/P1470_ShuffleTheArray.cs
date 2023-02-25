namespace LeetCode.Problems.Easy;

/// 重新排列数组
/// https://leetcode-cn.com/problems/shuffle-the-array/
public class P1470_ShuffleTheArray
{
    public int[] Shuffle(int[] nums, int n)
    {
        var ans = new int[nums.Length];
        var i = 0;
        var j = n;
        for (var k = 0; k < nums.Length; k++)
        {
            ans[k++] = nums[i++];
            ans[k] = nums[j++];
        }

        return ans;
    }
}