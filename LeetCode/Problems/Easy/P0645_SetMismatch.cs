namespace LeetCode.Problems
{
    /// 错误的集合
    /// https://leetcode-cn.com/problems/set-mismatch/
    public class P0645_SetMismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            int[] counter = new int[nums.Length + 1];
            foreach (var n in nums)
            {
                counter[n]++;
            }

            int[] result = new int[2];
            for (var i = 1; i < counter.Length; i++)
            {
                if (counter[i] == 0)
                {
                    result[1] = i;
                }
                else if (counter[i] == 2)
                {
                    result[0] = i;
                }
            }

            return result;
        }
    }
}