namespace LeetCode.Problems.Easy;

/// 是否所有 1 都至少相隔 k 个元素
/// https://leetcode-cn.com/problems/check-if-all-1s-are-at-least-length-k-places-away/
public class P1437_CheckIfAll1sAreAtLeastLengthKPlacesAway
{
    public bool KLengthApart(int[] nums, int k)
    {
        var counter = 0;
        var start = false;
        foreach (var num in nums)
            if (num == 1)
            {
                if (start && counter < k) return false;
                start = true;
                counter = 0;
            }
            else
            {
                counter++;
            }

        return true;
    }
}