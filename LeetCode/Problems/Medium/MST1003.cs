namespace LeetCode.Problems.Medium;

/// 搜索旋转数组
/// https://leetcode-cn.com/problems/search-rotate-array-lcci/
public class MST1003
{
    public int Search(int[] arr, int target)
    {
        for (var i = 0; i < arr.Length; i++)
            if (target == arr[i])
                return i;

        return -1;
    }
}