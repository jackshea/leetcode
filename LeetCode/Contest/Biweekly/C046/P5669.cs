namespace LeetCode.Contest.Biweekly.C046;

/// 通过连接另一个数组的子数组得到一个数组
/// https://leetcode-cn.com/contest/biweekly-contest-46/problems/form-array-by-concatenating-subarrays-of-another-array/
public class P5669
{
    public bool CanChoose(int[][] groups, int[] nums)
    {
        var m = groups.Length;
        var gi = 0;
        var ni = 0;
        while (ni < nums.Length && gi < m)
        {
            var check = true;
            for (var i = 0; i < groups[gi].Length; i++)
                if (ni + i >= nums.Length || groups[gi][i] != nums[ni + i])
                {
                    check = false;
                    break;
                }

            if (check)
            {
                ni += groups[gi].Length;
                gi++;
            }
            else
            {
                ni++;
            }
        }

        return gi >= m;
    }
}