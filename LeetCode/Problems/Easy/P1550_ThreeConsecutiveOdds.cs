namespace LeetCode.Problems.Easy;

/// 存在连续三个奇数的数组
/// https://leetcode-cn.com/problems/three-consecutive-odds/
public class P1550_ThreeConsecutiveOdds
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        var counter = 0;
        foreach (var num in arr)
            if (num % 2 == 0)
            {
                counter = 0;
            }
            else
            {
                counter++;
                if (counter >= 3) return true;
            }

        return false;
    }
}