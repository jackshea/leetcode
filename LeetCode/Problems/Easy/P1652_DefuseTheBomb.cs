namespace LeetCode.Problems.Easy
{
    /// 拆炸弹
    /// https://leetcode-cn.com/problems/defuse-the-bomb/
    public class P1652_DefuseTheBomb
    {
        public int[] Decrypt(int[] code, int k)
        {
            int[] ans = new int[code.Length];
            if (k == 0)
            {
                return ans;
            }

            if (k > 0)
            {
                int sum = 0;
                for (int i = 0; i < k; i++)
                {
                    sum += code[i];
                }

                for (int i = 0; i < code.Length; i++)
                {
                    sum += -code[i] + code[(i + k) % code.Length];
                    ans[i] = sum;
                }
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < -k; i++)
                {
                    sum += code[code.Length - 1 - i];
                }

                for (int i = code.Length - 1; i >= 0; i--)
                {
                    sum += -code[i] + code[(i + k + code.Length) % code.Length];
                    ans[i] = sum;
                }
            }

            return ans;
        }
    }
}