using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 用栈操作构建数组
    /// https://leetcode-cn.com/contest/weekly-contest-188/problems/build-an-array-with-stack-operations/
    public class P5404_BuildAnArrayWithStackOperations
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            IList<string> ans = new List<string>();
            if (target == null || target.Length == 0)
            {
                return ans;
            }
            int num = 1;
            int stackLen = 0;
            int i = 0;
            while (i < target.Length && num <= n)
            {
                if (target[i] == num++)
                {
                    ans.Add("Push");
                    stackLen++;
                    i++;
                    if (stackLen == target.Length)
                    {
                        break;
                    }
                }
                else
                {
                    ans.Add("Push");
                    ans.Add("Pop");
                }
            }

            return ans;
        }
    }
}