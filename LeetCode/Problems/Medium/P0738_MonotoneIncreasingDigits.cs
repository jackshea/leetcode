namespace LeetCode.Problems.Medium
{
    /// 单调递增的数字
    /// https://leetcode-cn.com/problems/monotone-increasing-digits/
    public class P0738_MonotoneIncreasingDigits
    {
        public int MonotoneIncreasingDigits(int N)
        {
            var ns = N.ToString().ToCharArray();
            int modifyIdx = -1;
            for (int i = ns.Length - 2; i >= 0; i--)
            {
                if (ns[i + 1] - ns[i] < 0)
                {
                    ns[i] = (char)(ns[i] - 1);
                    modifyIdx = i;
                }
            }
            if (modifyIdx < 0)
            {
                return N;
            }

            for (int i = modifyIdx + 1; i < ns.Length; i++)
            {
                ns[i] = '9';
            }

            return int.Parse(new string(ns));
        }
    }
}