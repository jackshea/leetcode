namespace LeetCode.Problems
{
    /// 山脉数组的峰顶索引
    /// https://leetcode-cn.com/problems/peak-index-in-a-mountain-array/
    public class P0852_PeakIndexInAMountainArray
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int left = 0, right = A.Length - 1;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (A[mid] > A[mid - 1] && A[mid] > A[mid + 1])
                {
                    return mid;
                }

                if (A[mid] < A[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
}