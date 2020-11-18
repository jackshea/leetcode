namespace LeetCode.Problems.Medium
{
    /// 神奇字符串
    /// https://leetcode-cn.com/problems/magical-string/
    public class P0481_MagicalString
    {
        public int MagicalString(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            int[] line = new int[n];
            int slow = 0;
            int fast = 0;
            int ans = 0;
            int num = 1;
            while (fast < n)
            {
                if (line[slow] == 0)
                {
                    line[slow] = num;
                }

                for (int i = 0; i < line[slow]; i++)
                {
                    line[fast++] = num;
                    if (num == 1)
                    {
                        ans++;
                    }
                    if (fast >= n)
                    {
                        return ans;
                    }
                }

                slow++;
                num = num == 1 ? 2 : 1;
            }

            return ans;
        }
    }
}