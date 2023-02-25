namespace LeetCode.Problems.Easy;

/// 数组元素积的符号
/// https://leetcode-cn.com/problems/sign-of-the-product-of-an-array/
public class P1822_SignOfTheProductOfAnArray
{
    public int ArraySign(int[] nums)
    {
        var sign = 1;
        foreach (var num in nums)
            if (num < 0)
                sign = -sign;
            else if (num == 0) return 0;

        return sign;
    }
}