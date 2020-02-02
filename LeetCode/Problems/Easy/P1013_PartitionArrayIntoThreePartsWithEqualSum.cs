using System.Linq;

namespace LeetCode.Problems.Easy
{
    /// 将数组分成和相等的三个部分
    /// https://leetcode-cn.com/problems/partition-array-into-three-parts-with-equal-sum/
    public class P1013_PartitionArrayIntoThreePartsWithEqualSum
    {
        public bool CanThreePartsEqualSum(int[] A)
        {
            var sum = A.Sum();
            if (sum % 3 != 0)
            {
                return false;
            }

            var avg = sum / 3;
            int left = 0;
            int right = A.Length - 1;
            int leftSum = 0;
            int rightSum = 0;
            while (left < right)
            {
                if (leftSum != avg)
                {
                    leftSum += A[left++];
                }

                if (rightSum != avg)
                {
                    rightSum += A[right--];
                }

                if (leftSum == avg && rightSum == avg)
                {
                    return true;
                }
            }

            return false;
        }
    }
}