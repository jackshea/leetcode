namespace LeetCode.Problems.Easy;

/// 面试题62. 圆圈中最后剩下的数字
/// https://leetcode-cn.com/problems/yuan-quan-zhong-zui-hou-sheng-xia-de-shu-zi-lcof/
public class MST62
{
    public int LastRemaining(int n, int m)
    {
        if (n == 1) return 0;

        return (m + LastRemaining(n - 1, m)) % n;
    }
}