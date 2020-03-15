namespace LeetCode.Problems.Easy
{
    /// 旋转数组
    /// https://leetcode-cn.com/problems/rotate-array/
    public class P0189_RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            int count = 0;
            for (int start = 0; count < nums.Length; start++)
            {
                int current = start;
                int prev = nums[start];
                do
                {
                    int next = (current + k) % nums.Length;
                    int temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    current = next;
                    count++;
                } while (start != current);
            }
        }
    }
}