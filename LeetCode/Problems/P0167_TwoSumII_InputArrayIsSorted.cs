namespace LeetCode.Problems
{
    public class P0167_TwoSumII_InputArrayIsSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;
            while (left < right)
            {
                var sum = numbers[left] + numbers[right];
                if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                {
                    right--;
                }
                else
                {
                    return new[] { left + 1, right + 1 };
                }
            }

            return null;
        }
    }
}