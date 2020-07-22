namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 11. 旋转数组的最小数字
    /// https://leetcode-cn.com/problems/xuan-zhuan-shu-zu-de-zui-xiao-shu-zi-lcof/
    public class Offer11
    {
        public int MinArray(int[] numbers)
        {
            int left = 0, right = numbers.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (numbers[mid] < numbers[right])
                {
                    right = mid;
                }
                else if (numbers[mid] > numbers[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right--;
                }
            }

            return numbers[left];
        }
    }
}