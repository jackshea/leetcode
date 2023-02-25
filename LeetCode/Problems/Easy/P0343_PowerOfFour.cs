namespace LeetCode.Problems.Easy;

/// 4的幂
/// https://leetcode-cn.com/problems/power-of-four/submissions/
public class P0343_PowerOfFour
{
    public bool IsPowerOfFour(int num)
    {
        if (num < 0 || (num & (num - 1)) != 0)
            //check(is or not) a power of 2.
            return false;
        return (num & 0x55555555) != 0; //check 1 on odd bits
    }
}