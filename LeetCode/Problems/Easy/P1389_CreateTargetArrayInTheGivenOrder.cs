namespace LeetCode.Problems.Easy
{
    /// 按既定顺序创建目标数组
    /// https://leetcode-cn.com/problems/create-target-array-in-the-given-order/
    public class P1389_CreateTargetArrayInTheGivenOrder
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] ans = new int[nums.Length];
            int curLenth = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int insertIndex = index[i];
                for (int j = curLenth; j > insertIndex; j--)
                {
                    ans[j] = ans[j - 1];
                }

                ans[insertIndex] = nums[i];
                curLenth++;
            }

            return ans;
        }
    }
}