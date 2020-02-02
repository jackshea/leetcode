namespace LeetCode.Problems.Easy
{
    /// 旋转字符串
    /// https://leetcode-cn.com/problems/rotate-string/
    public class P0796_RotateString
    {
        public bool RotateString(string A, string B)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            return (A + A).Contains(B);
        }
    }
}