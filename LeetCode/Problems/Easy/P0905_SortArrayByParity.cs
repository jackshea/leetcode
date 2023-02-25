namespace LeetCode.Problems.Easy;

/// 按奇偶排序数组
/// https://leetcode-cn.com/problems/sort-array-by-parity/
public class P0905_SortArrayByParity
{
    public int[] SortArrayByParity(int[] A)
    {
        var left = 0;
        var right = A.Length - 1;
        while (left < right)
        {
            if (A[left] % 2 == 0)
            {
                left++;
                continue;
            }

            if (A[right] % 2 != 0)
            {
                right--;
                continue;
            }

            var temp = A[left];
            A[left] = A[right];
            A[right] = temp;
            left++;
            right--;
        }

        return A;
    }
}