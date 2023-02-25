namespace LeetCode.Problems.Medium;

/// 部分排序
/// https://leetcode-cn.com/problems/sub-sort-lcci/
public class MST1616
{
    public int[] SubSort(int[] array)
    {
        if (array == null || array.Length < 1) return new[] { -1, -1 };

        // 从左往右找右端点
        var max = array[0];
        var right = -1;
        var n = array.Length;
        for (var i = 1; i < n; i++)
            if (array[i] >= max)
                max = array[i];
            else
                right = i;
        if (right == -1) return new[] { -1, -1 };
        // 从右往左找左端点
        var min = array[n - 1];
        var left = -1;
        for (var i = n - 1; i >= 0; i--)
            if (array[i] <= min)
                min = array[i];
            else
                left = i;
        return new[] { left, right };
    }
}