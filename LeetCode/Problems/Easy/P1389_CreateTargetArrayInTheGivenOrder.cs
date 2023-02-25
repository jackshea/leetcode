namespace LeetCode.Problems.Easy;

/// 按既定顺序创建目标数组
/// https://leetcode-cn.com/problems/create-target-array-in-the-given-order/
public class P1389_CreateTargetArrayInTheGivenOrder
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        var ans = new int[nums.Length];
        var curLenth = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            var insertIndex = index[i];
            for (var j = curLenth; j > insertIndex; j--) ans[j] = ans[j - 1];

            ans[insertIndex] = nums[i];
            curLenth++;
        }

        return ans;
    }
}