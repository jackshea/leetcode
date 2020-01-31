namespace LeetCode.Problems
{
    /// 统计位数为偶数的数字
    /// https://leetcode-cn.com/problems/find-numbers-with-even-number-of-digits/
    public class P1295_FindNumbersWithEvenNumberOfDigits
    {
        public int FindNumbers(int[] nums)
        {
            int ans = 0;
            foreach (var num in nums)
            {
                int count = 0;
                int n = num;
                while (n > 0)
                {
                    count++;
                    n /= 10;
                }

                if (count %2==0)
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}