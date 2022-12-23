namespace LeetCode.Problems.Easy
{
    /// 执行操作后的变量值
    /// https://leetcode.cn/problems/final-value-of-variable-after-performing-operations/
    public class P2011_FinalValueOfVariableAfterPerformingOperations
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int ans = 0;
            foreach (var operation in operations)
            {
                if (operation=="X++" || operation=="++X")
                {
                    ans++;
                }
                else
                {
                    ans--;
                }
            }

            return ans;
        }
    }
}