namespace LeetCode.Problems.Easy;

/// 旋转数组
/// https://leetcode-cn.com/problems/rotate-array/
public class P0189_RotateArray
{
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        var count = 0;
        for (var start = 0; count < nums.Length; start++)
        {
            var current = start;
            var prev = nums[start];
            do
            {
                var next = (current + k) % nums.Length;
                var temp = nums[next];
                nums[next] = prev;
                prev = temp;
                current = next;
                count++;
            } while (start != current);
        }
    }
}