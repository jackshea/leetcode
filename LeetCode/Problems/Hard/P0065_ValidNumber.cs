namespace LeetCode.Problems.Hard
{
    /// 有效数字
    /// https://leetcode-cn.com/problems/valid-number/
    public class P0065_ValidNumber
    {
        public bool IsNumber(string s)
        {
            int state = 0;
            int finals = 0b101101000;
            int[,] transfer = new int[,]{{ 0, 1, 6, 2,-1},
                {-1,-1, 6, 2,-1},
                {-1,-1, 3,-1,-1},
                { 8,-1, 3,-1, 4},
                {-1, 7, 5,-1,-1},
                { 8,-1, 5,-1,-1},
                { 8,-1, 6, 3, 4},
                {-1,-1, 5,-1,-1},
                { 8,-1,-1,-1,-1}};
            char[] ss = s.ToCharArray();
            for (int i = 0; i < ss.Length; ++i)
            {
                int id = Make(ss[i]);
                if (id < 0) return false;
                state = transfer[state, id];
                if (state < 0) return false;
            }
            return (finals & (1 << state)) > 0;
        }

        public int Make(char c)
        {
            switch (c)
            {
                case ' ': return 0;
                case '+':
                case '-': return 1;
                case '.': return 3;
                case 'e':
                case 'E': return 4;
                default:
                    return c >= 48 && c <= 57 ? 2 : -1;
            }
        }
    }
}